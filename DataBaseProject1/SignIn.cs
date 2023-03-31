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

 // ____            _____            __          _ 
 //|  _ \          / ____|          / _|        | |
 //| |_) |   ___  | (___     __ _  | |_    ___  | |
 //|  _ <   / _ \  \___ \   / _` | |  _|  / _ \ | |
 //| |_) | |  __/  ____) | | (_| | | |   |  __/ |_|
 //|____/   \___| |_____/   \__,_| |_|    \___| (_)
                                                 
                                                 

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
            //using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter
            //        ("Select Count(*) From USERS where USERNAME='" + outsideLogin.Text + "' and PASSWORD ='"
            //        + outsidePassword.Text + "'", conn);

            //    DataTable dataTable = new DataTable();
            //    da.Fill(dataTable);

            //    if (dataTable.Rows[0][0].ToString() == "1")
            //    {
            //        this.Hide();
            //        LoggedIn loggedIn = new LoggedIn();
            //        loggedIn.Show();
            //    }

            //    else
            //    {
            //        MessageBox.Show("Wrong username or password!");
            //    }
            //}
            //focus.Focus();
            //MessageBox.Show(UserIDGenerator.CreateUserID(8));
            //MessageBox.Show(SecureData.HashPassword(outsideLogin.Text)); 



            byte[] pwd = Encoding.ASCII.GetBytes(outsidePassword.Text);
            byte[] salt = Encoding.ASCII.GetBytes(SecureData.CreateSalt(8));

            
            MessageBox.Show(SecureData.HashPassword(outsidePassword.Text, salt));
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