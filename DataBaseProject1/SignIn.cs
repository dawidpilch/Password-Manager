﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


 // _____                 _             
 //|_   _|   ___       __| |   ___    _ 
 //  | |    / _ \     / _` |  / _ \  (_)
 //  | |   | (_) |   | (_| | | (_) |  _ 
 //  |_|    \___/     \__,_|  \___/  (_)



namespace DataBaseProject1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            showPassword.Visible = true;
            hidePassword.Visible = false;
            outsidePassword.UseSystemPasswordChar = true;
            focus.Focus();
        }

        public void loginButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(outsideUsername.Text) && !string.IsNullOrEmpty(outsidePassword.Text))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                {
                    conn.Open();

                    //Checking if User Exists
                    SqlCommand cmdDoesUserExist = new SqlCommand
                        ("SELECT COUNT(*) [USERNAME] FROM [DataBaseProject1].[dbo].[USERS] WHERE [USERNAME] = '"
                        + outsideUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS;", conn);
                    string cmdDoesUserExistResult = cmdDoesUserExist.ExecuteScalar().ToString();

                    if (cmdDoesUserExistResult != "0")
                    {
                        usernameInfo.Visible = false;
                        outsideUsername.BackColor = Color.FromArgb(255, 255, 255);
                        outsideUsername.ForeColor = Color.FromArgb(0, 0, 0);

                        //If User Exists, find their salt
                        SqlCommand cmdGetUsersSalt = new SqlCommand
                            ("SELECT [PASSWORDSALT] FROM [DataBaseProject1].[dbo].[USERS] WHERE [USERNAME] = '"
                            + outsideUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", conn);
                        string cmdGetUsersSaltResult = cmdGetUsersSalt.ExecuteScalar().ToString();

                        byte[] cmdGetUserSaltResultByte = Encoding.ASCII.GetBytes(cmdGetUsersSaltResult);

                        string passwordCheck = SecureData.HashPassword(outsidePassword.Text, cmdGetUserSaltResultByte);


                        //Comparing Hashed Passwords
                        SqlCommand cmdComparePasswords = new SqlCommand
                            ("SELECT COUNT(*) [PASSWORD] FROM [DataBaseProject1].[dbo].[USERS] WHERE [USERNAME] = '"
                            + outsideUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                            "AND [PASSWORD] = '" + passwordCheck + "'", conn);
                        string cmdComparePasswordsResult = cmdComparePasswords.ExecuteScalar().ToString();

                        if (cmdComparePasswordsResult == "1")
                        {
                            passwordInfo.Visible = false;
                            MessageBox.Show("Hello " + outsideUsername.Text + "! \n" + passwordCheck);
                        }
                    }

                    else 
                    {
                        usernameInfo.Visible = true;
                        outsideUsername.BackColor = Color.FromArgb(192, 0, 0);
                        outsideUsername.ForeColor = Color.FromArgb(255, 255, 255);
                    }

                    
                    conn.Close();
                }
            }

            if (string.IsNullOrEmpty(outsideUsername.Text))
            {
                usernameInfo.Visible = true;
                outsideUsername.BackColor = Color.FromArgb(192, 0, 0);
                outsideUsername.ForeColor = Color.FromArgb(255, 255, 255);
            }

            if (string.IsNullOrEmpty(outsidePassword.Text))
            {
                passwordInfo.Visible = true;
                outsidePassword.BackColor = Color.FromArgb(192, 0, 0);
                outsidePassword.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void goToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            showPassword.Visible = false;
            hidePassword.Visible = true;
            outsidePassword.UseSystemPasswordChar = false;
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            showPassword.Visible = true;
            hidePassword.Visible = false;
            outsidePassword.UseSystemPasswordChar = true;
        }
    }
}
