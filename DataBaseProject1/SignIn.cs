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
using DataBaseProject1.Data_Base;
using DataBaseProject1.Services;

namespace DataBaseProject1
{
    public partial class SignIn : Form
    {
        public static string Username;

        Connections connections = new Connections();
        

        public SignIn()
        {
            InitializeComponent();
            showPassword.Visible = true;
            hidePassword.Visible = false;
            outsidePassword.UseSystemPasswordChar = true;
            focus.Focus();
        }

        public async void loginButton_Click_1(object sender, EventArgs e)
        {
            User userServices = new User();

            if (!string.IsNullOrEmpty(outsideUsername.Text) && !string.IsNullOrEmpty(outsidePassword.Text))
            {
                if (await userServices.Login(outsideUsername.Text, outsidePassword.Text))
                {
                    passwordInfo.Visible = false;
                    Username = outsideUsername.Text;
                    this.Hide();
                    LoggedIn loggedIn = new LoggedIn();
                    loggedIn.Show();
                }

                else
                {
                    usernameInfo.Visible = true;
                    outsideUsername.BackColor = Color.FromArgb(192, 0, 0);
                    outsideUsername.ForeColor = Color.FromArgb(255, 255, 255);
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
