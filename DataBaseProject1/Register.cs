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
using DataBaseProject1.Data_Base;
using DataBaseProject1.Services;
using System.Threading;

namespace DataBaseProject1
{
    public partial class Register : Form
    {
        private static bool PasswordAccepted;
        private static bool PhoneNumberAccepted;
        private static bool EmailIsValid;
        private static bool EmailNotTaken;

        public Register()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            labelfocus.Select();
        }

        private void goToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn form = new SignIn();
            form.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }
        
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            #region //======= Email TextBox =======//
            if (string.IsNullOrEmpty(emailRegister.Text))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                emailInfo.Text = "Enter an email";
                emailInfo.Visible = true;
                EmailIsValid = false;
            }

            else if (!emailRegister.Text.Contains("@"))
            {
                emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                emailInfo.Text = "Invalid email!";
                emailInfo.Visible = true;
                EmailIsValid = false;
            }

            else
            {
                emailRegister.BackColor = Color.FromArgb(255, 255, 255);
                emailRegister.ForeColor = Color.FromArgb(0, 0, 0);
                emailInfo.Visible = false;
                EmailIsValid = true;
            }

            //Checking if email is already not taken
            if (EmailIsValid)
            {
                if (!await User.IsEmailAvailable(emailRegister.Text))
                {
                    EmailNotTaken = false;
                    emailInfo.Visible = true;
                    emailInfo.Text = "This email is already connected to an account!\r\n";
                    emailRegister.BackColor = Color.FromArgb(192, 0, 0);
                    emailRegister.ForeColor = Color.FromArgb(255, 255, 255);
                }

                else
                {
                    emailRegister.BackColor = Color.FromArgb(255, 255, 255);
                    emailRegister.ForeColor = Color.FromArgb(0, 0, 0);
                    emailInfo.Visible = false;
                    EmailNotTaken = true;
                }
            }
            #endregion


            #region //======= Password TextBox =======//
            if (passwordRegister.Text.Length < 8)
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

            if (PasswordAccepted)
            {
                

                if (string.IsNullOrEmpty(passwordRegisterConfirmation.Text))
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(192, 0, 0);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(255, 255, 255);
                    passwordInfo.ForeColor = Color.FromArgb(192, 0, 0);
                    passwordInfo.Text = "Confirm your password.";
                }

                else if (!passwordRegister.Text.Equals(passwordRegisterConfirmation.Text))
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(192, 0, 0);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(255, 255, 255);
                    passwordInfo.ForeColor = Color.FromArgb(192, 0, 0);
                    passwordInfo.Text = "Those passwords didn't match. Try again.";
                }

                else
                {
                    passwordRegisterConfirmation.BackColor = Color.FromArgb(255, 255, 255);
                    passwordRegisterConfirmation.ForeColor = Color.FromArgb(0, 0, 0);
                    passwordInfo.Visible = false;
                }
            }
            #endregion


            #region //======= Phone Number TextBox =======//
            PhoneNumberAccepted = DataValidation.IsDigitsOnly(phoneRegister.Text);

            if (!PhoneNumberAccepted)
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


            //Creating new account
            if (PasswordAccepted && PasswordAccepted && EmailNotTaken && PhoneNumberAccepted)
            {
                if (await User.CreateNewAccount(passwordRegister.Text, emailRegister.Text, phoneRegister.Text)){
                    MessageBox.Show("Registered Successfully!");
                    this.Close();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
            }
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
