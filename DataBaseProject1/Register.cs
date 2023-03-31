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


 // _____                 _             
 //|_   _|   ___       __| |   ___    _ 
 //  | |    / _ \     / _` |  / _ \  (_)
 //  | |   | (_) |   | (_| | | (_) |  _ 
 //  |_|    \___/     \__,_|  \___/  (_)
                                      
    // -> New Unique Username System [X]
    // -> Password Logic to accept only UTF-8 Characters



namespace DataBaseProject1
{
    public partial class Register : Form
    {

        public static string NewID = "987654321";

        public static bool UsernameAccepted;
        public static bool UsernameAvailable;
        public static bool PasswordAccepted;
        public static bool PhoneNumberAccepted;
        public static bool EmailAccepted;
        public static bool UniqueUsername;

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
            if (usernameRegister.Text.Length < 5)
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                usernameInfo.Visible = true;
                UsernameAccepted = false;
            }
            
            else if (!usernameRegister.Text.All(Char.IsLetterOrDigit))
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                usernameInfo.Visible = true;
                UsernameAccepted = false;
            }

            else
            {
                usernameRegister.BackColor = Color.FromArgb(255, 255, 255);
                usernameRegister.ForeColor = Color.FromArgb(0, 0, 0);
                usernameInfo.Visible = false;
                UsernameAccepted = true;
            }

            //Checking if Username is not already taken
            if (UsernameAccepted == true)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand cmdUsernameCheck = new SqlCommand("Select Count(*) From USERS where USERNAME='" + usernameRegister.Text + "'", conn);
                    string cmdUsernameResult = cmdUsernameCheck.ExecuteScalar().ToString();

                    if (cmdUsernameResult == "0")
                    {
                        UniqueUsername = true;
                        usernameInfoTaken.Visible = false;
                        usernameRegister.BackColor = Color.FromArgb(255, 255, 255);
                        usernameRegister.ForeColor = Color.FromArgb(0, 0, 0);
                    }

                    else
                    {
                        UniqueUsername = false;
                        usernameInfoTaken.Visible = true;
                        usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                        usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    conn.Close();
                    
                }
            }


            //======= Password TextBox =======//
            if (passwordRegister.Text.Length < 8)
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

            else if (!emailRegister.Text.Contains("@"))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                emailInfo.Visible = true;
                EmailAccepted = false;
            }

            else
            {
                emailRegister.BackColor = Color.FromArgb(255, 255, 255);
                emailRegister.ForeColor = Color.FromArgb(0, 0, 0);
                emailInfo.Visible = false;
                EmailAccepted = true;
            }


            //======= Phone Number TextBox =======//
            PhoneNumberAccepted = IsDigitsOnly(phoneRegister.Text);


            //Checking if all Required Fields are filled. If not, the Connection with a DB won't be established
            //and the data will not land in the DB.
            if (UsernameAccepted == true && UniqueUsername == true && PasswordAccepted == true && EmailAccepted == true && PhoneNumberAccepted == true)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();

                    SqlDataAdapter getLatestID = new SqlDataAdapter("SELECT MAX(ID) AS MaxID FROM [DataBaseProject1].[dbo].[USERS]", conn);

                    DataTable dataTable = new DataTable();
                    getLatestID.Fill(dataTable);
                    string tostring = dataTable.Rows[0][0].ToString();
                    int latestID = int.Parse(tostring);
                    int NewID = latestID + 1;


                    //Salts for Username and Password
                    string passwordSalt = SecureData.CreateSalt(8);
                    byte[] passwordSaltByte = Encoding.ASCII.GetBytes(passwordSalt);

                    //string usernameSalt = SecureData.CreateSalt(8);
                    //byte[] usernameSaltByte = Encoding.ASCII.GetBytes(usernameSalt);


                    //Inserting into DataBase
                    command = new SqlCommand
                        ("Insert into USERS (ID, USERNAME, PASSWORD, EMAIL, PHONENUMBER, DATE, PASSWORDSALT) values ('" +

                        //ID
                        NewID + "', '" +

                        //USERNAME
                        usernameRegister.Text + "', '" +

                        //PASSWORD
                        SecureData.HashPassword(passwordRegister.Text, passwordSaltByte) + "', '" +

                        //EMAIL
                        emailRegister.Text + "', '" +

                        //PHONENUMBER
                        phoneRegister.Text + "', '" +

                        //REGISTER DATE
                        DateTime.UtcNow.ToString("yyyy-MM-dd") + "', '" +

                        //SALT
                        passwordSalt + "')", conn);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Registered Successfully!");
                    }
                    conn.Close();
                }
            }

            else
            {
                MessageBox.Show("Missing the Required Data!");
            }
        }

        private void emailInfo_Click(object sender, EventArgs e)
        {
            
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
