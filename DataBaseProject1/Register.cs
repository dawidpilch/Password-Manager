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
                                      
//



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
        public static bool UniqueEmail;

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
            
            #region //======= Username TextBox =======//
            usernameInfo.Text = "You can use letters and numbers.\r\n";
            if (usernameRegister.Text.Length < 6 || usernameRegister.Text.Length > 30)
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                usernameInfo.Text = "Your Username must be between 6 and 30 \r\ncharacters long.\r\n";
                usernameInfo.ForeColor = Color.FromArgb(192, 0, 0);
                UsernameAccepted = false;
            }
            
            else if (!usernameRegister.Text.All(Char.IsLetterOrDigit))
            {
                usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                usernameInfo.Text = "Only letters and numbers are allowed!\r\n";
                usernameInfo.ForeColor = Color.FromArgb(192, 0, 0);
                UsernameAccepted = false;
            }

            else
            {
                usernameRegister.BackColor = Color.FromArgb(255, 255, 255);
                usernameRegister.ForeColor = Color.FromArgb(0, 0, 0);
                UsernameAccepted = true;
                usernameInfo.Text = "You can use letters and numbers.\r\n";
                usernameInfo.ForeColor = Color.DarkGray;
            }

            //Checking if Username is not already taken
            if (UsernameAccepted == true)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand cmdUsernameCheck = new SqlCommand("Select Count(*) From USERS where USERNAME='" + usernameRegister.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", conn);
                    string cmdUsernameResult = cmdUsernameCheck.ExecuteScalar().ToString();

                    if (cmdUsernameResult == "0")
                    {
                        UniqueUsername = true;
                        usernameInfo.Text = "You can use letters and numbers.\r\n";
                        usernameInfo.ForeColor = Color.DarkGray;
                        usernameRegister.BackColor = Color.FromArgb(255, 255, 255);
                        usernameRegister.ForeColor = Color.FromArgb(0, 0, 0);
                    }

                    else
                    {
                        UniqueUsername = false;
                        usernameInfo.Text = "Username already taken!\r\n";
                        usernameInfo.ForeColor = Color.FromArgb(192, 0, 0);
                        usernameRegister.BackColor = Color.FromArgb(192, 0, 0);
                        usernameRegister.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    conn.Close();
                }
            }
            #endregion


            #region //======= Password TextBox =======//
            bool passwordCharsAllowed = passwordRegister.Text.All(c => SecureData.chars.Contains(c));


            if (passwordRegister.Text.Length < 8 || passwordCharsAllowed == false)
            {
                passwordRegister.BackColor = Color.FromArgb(192, 0, 0);
                passwordRegister.ForeColor = Color.FromArgb(255, 255, 255);
                passwordRegisterConfirmation.BackColor = Color.FromArgb(255, 255, 255);
                passwordRegisterConfirmation.ForeColor = Color.FromArgb(0, 0, 0);
                passwordInfo.ForeColor = Color.FromArgb(192, 0, 0);
                passwordInfo.Text = "Use 8 or more characters with a mix of letters, \r\nnumbers and symbols.";
                PasswordAccepted = false;
                passwordInfo.Visible = true;
            }

            else
            {
                passwordRegister.BackColor = Color.FromArgb(255, 255, 255);
                passwordRegister.ForeColor = Color.FromArgb(0, 0, 0);
                passwordRegisterConfirmation.BackColor = Color.FromArgb(255, 255, 255);
                passwordRegisterConfirmation.ForeColor = Color.FromArgb(0, 0, 0);
                passwordInfo.ForeColor = Color.DarkGray;
                PasswordAccepted = true;
                passwordInfo.Visible = true;
            }

            if (PasswordAccepted == true)
            {
                bool passwordConfirmed = passwordRegister.Text.Equals(passwordRegisterConfirmation.Text);

                if (string.IsNullOrEmpty(passwordRegisterConfirmation.Text))
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(192, 0, 0);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(255, 255, 255);
                    passwordInfo.ForeColor = Color.FromArgb(192, 0, 0);
                    passwordInfo.Text = "Confirm your password.";
                }

                else if (passwordConfirmed == true)
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(255, 255, 255);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(0, 0, 0);
                    passwordInfo.Visible = false;
                }

                else
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(192, 0, 0);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(255, 255, 255);
                    passwordInfo.ForeColor = Color.FromArgb(192, 0, 0);
                    passwordInfo.Text = "Those passwords didn't match. Try again.";
                }
            }
            #endregion


            #region //======= Email Adress TextBox =======//
            if (string.IsNullOrEmpty(emailRegister.Text))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                emailInfo.Text = "Invalid E-Mail!";
                emailInfo.Visible = true;
                EmailAccepted = false;
            }

            else if (!emailRegister.Text.Contains("@"))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                emailInfo.Text = "Invalid E-Mail!";
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

            //Checking if E-Mail is no already in use
            if (EmailAccepted == true)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                {
                    conn.Open();
                    SqlCommand cmdEmailCheck = new SqlCommand("Select Count(*) From USERS where EMAIL='" + emailRegister.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", conn);
                    string cmdEmailResult = cmdEmailCheck.ExecuteScalar().ToString();

                    if (cmdEmailResult == "0")
                    {
                        UniqueEmail = true;
                        emailInfo.Visible = false;
                    }

                    else
                    {
                        UniqueEmail = false;
                        emailInfo.Visible = true;
                        emailInfo.Text = "This email is already connected to an account!\r\n";
                        emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                        emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    conn.Close();
                }
            }

            #endregion


            #region //======= Phone Number TextBox =======//
            PhoneNumberAccepted = IsDigitsOnly(phoneRegister.Text);

            if (PhoneNumberAccepted == false)
            {
                phoneRegister.BackColor = Color.FromArgb(192, 0, 0);
                phoneRegister.ForeColor = Color.FromArgb(255, 255, 255);
                phoneInfo.Visible = true;
            }

            else
            {
                phoneRegister.BackColor = Color.FromArgb(255, 255, 255);
                phoneRegister.ForeColor = Color.FromArgb(0, 0, 0);
                phoneInfo.Visible = false;
            }
            #endregion


            //Checking if all Required Fields are filled and accepted. If not, the Connection with a DB won't be established
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

        private void showPassword_Click(object sender, EventArgs e)
        {
            showPassword.Visible = false;
            hidePassword.Visible = true;
            passwordRegister.UseSystemPasswordChar = false;
            passwordRegisterConfirmation.UseSystemPasswordChar = false;
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            showPassword.Visible = true;
            hidePassword.Visible = false;
            passwordRegister.UseSystemPasswordChar = true;
            passwordRegisterConfirmation.UseSystemPasswordChar = true;
        }
    }
}
