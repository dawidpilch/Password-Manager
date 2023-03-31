using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DataBaseProject1
{
    public partial class Register : Form
    {

        public static string NewID = "987654321";

        public static bool UsernameAccepted;
        public static bool PasswordAccepted;
        public static bool PhoneNumberAccepted;
        public static bool EmailAccepted;


        public Register()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            labelfocus.Select();
        }

        private void goToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn form = new SignIn();
            form.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }
        
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //======= Username TextBox =======//
            if (string.IsNullOrEmpty(usernameRegister.Text))
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                UsernameAccepted = false;
            }
            //usernameRegister.Text.Contains('x')
            else if (!usernameRegister.Text.All(Char.IsLetterOrDigit))
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                usernameInfo.Visible = true;
                EmailAccepted = false;
            }

            else
            {
                usernameRegister.BackColor = Color.FromArgb(255, 255, 255);
                usernameRegister.ForeColor = Color.FromArgb(0, 0, 0);
                UsernameAccepted = true;
            }


            //======= Password TextBox =======//
            if (string.IsNullOrEmpty(passwordRegister.Text))
            {
                passwordRegister.BackColor = Color.FromArgb(192, 0, 0);
                passwordRegister.ForeColor = Color.FromArgb(255, 255, 255);
                PasswordAccepted = false;
            }

            else
            {
                passwordRegister.BackColor = Color.FromArgb(255, 255, 255);
                passwordRegister.ForeColor = Color.FromArgb(0, 0, 0); 
                PasswordAccepted = true;
            }


            //======= Email Adress TextBox =======//
            if (string.IsNullOrEmpty(emailRegister.Text))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                EmailAccepted = false;
            }

            else
            {
                emailRegister.BackColor = Color.FromArgb(255, 255, 255);
                emailRegister.ForeColor = Color.FromArgb(0, 0, 0);
                EmailAccepted = true;
            }


            //======= Phone Number TextBox =======//
            PhoneNumberAccepted = IsDigitsOnly(phoneRegister.Text);




            SqlCommand command = new SqlCommand();
            //Checking if all Required Fields are filled. If not, the Connection with a DB won't be established
            //and the data will not land in the DB.
            if (UsernameAccepted == true && PasswordAccepted == true && EmailAccepted == true && PhoneNumberAccepted == true)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;");
                conn.Open();


                #region Old Scripts
                //SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From USERS where ID ='" + NewID + "'", conn);

                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);

                //if (dataTable.Rows[0][0].ToString() == "1")
                //{
                //    MessageBox.Show("ID zajęte");
                //}

                //else
                //{
                //    MessageBox.Show("Dostępne");
                //}


                //SqlCommand cmdUser = new SqlCommand("Select Count(*) From USERS where ID = '" + NewID + "'", conn);

                //var cmdUserResult = cmdUser.ExecuteScalar();


                //if (cmdUserResult != null)
                //{
                //    MessageBox.Show("ID Niedostępne");
                //}

                //else
                //{
                //    MessageBox.Show("ID git");
                //}
                #endregion

                SqlDataAdapter getLatestID = new SqlDataAdapter("SELECT MAX(ID) AS MaxID FROM [DataBaseProject1].[dbo].[USERS]", conn);

                DataTable dataTable = new DataTable();
                getLatestID.Fill(dataTable);                
                string tostring = dataTable.Rows[0][0].ToString();
                int latestID = int.Parse(tostring);
                int NewID = latestID + 1;

                //Todays Date for SQL
                //MessageBox.Show(DateTime.UtcNow.ToString("dd-MM-yyyy") + NewID);

                string passwordSalt = SecureData.CreateSalt(8);
                byte[] passwordSaltByte = Encoding.ASCII.GetBytes(passwordSalt);

                string usernameSalt = SecureData.CreateSalt(8);
                byte[] usernameSaltByte = Encoding.ASCII.GetBytes(usernameSalt);

                //Inserting into DataBase
                command = new SqlCommand
                    ("Insert into USERS (ID, USERNAME, PASSWORD, EMAIL, PHONENUMBER, DATE, USERNAMESALT, PASSWORDSALT) values ('" +
                    
                    //ID
                    NewID + "', '" +

                    //USERNAME
                    SecureData.HashPassword(usernameRegister.Text, passwordSaltByte) + "', '" +

                    //PASSWORD
                    SecureData.HashPassword(passwordRegister.Text, usernameSaltByte) + "', '" +

                    //EMAIL
                    emailRegister.Text + "', '" +

                    //PHONENUMBER
                    phoneRegister.Text + "', '" +

                    //REGISTER DATE
                    DateTime.UtcNow.ToString("yyyy-MM-dd") + "', '" +

                    //SALT
                    usernameSalt + "', '" + passwordSalt + "')", conn);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Registered Successfully!");
                }
                conn.Close();
            }

            else
            {
                MessageBox.Show("Missing the Required Data!");
            }
            
        }

        private void emailInfo_Click(object sender, EventArgs e)
        {
            usernameInfo.Visible = false;
        }

        private void passwordRegister_Enter(object sender, EventArgs e)
        {
            passwordInfo.Visible = true;
        }

        private void passwordRegister_Leave(object sender, EventArgs e)
        {
            passwordInfo.Visible = false;
        }

        private void phoneRegister_Enter(object sender, EventArgs e)
        {
            phoneInfo.Visible = true;
        }

        private void phoneRegister_Leave(object sender, EventArgs e)
        {
            phoneInfo.Visible = false;
        }

        private void usernameRegister_Enter(object sender, EventArgs e)
        {
            usernameInformation.Visible = true;
        }

        private void usernameRegister_Leave(object sender, EventArgs e)
        {
            usernameInformation.Visible = false;
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
