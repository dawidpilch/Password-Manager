using DataBaseProject1.Data_Base;
using DataBaseProject1.Models;
using DataBaseProject1.Services;
using System;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace DataBaseProject1.LoggedInChildForms
{
    public partial class NewLogin : Form
    {
        public static NewLogin instance;

        public int isLoginFavorite = 0;
        public int rePrompt = 0;

        public NewLogin()
        {
            InitializeComponent();
            instance = this;
        }

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (favoriteCheckBox.Checked)
            {
                isLoginFavorite = 1;
            }

            else
            {
                isLoginFavorite = 0;
            }
        }

        private void RePromptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RePromptCheckBox.Checked)
            {
                rePrompt = 1;
            }

            else
            {
                rePrompt = 0;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            NewLoginModel loginModel = new NewLoginModel();
            loginModel.userId = LoggedIn.userID;
            loginModel.name = newLoginName.Text;
            loginModel.username = newLoginUsername.Text;
            loginModel.password = newLoginPassword.Text;
            loginModel.authenticatorKey = newLoginTOTP.Text;
            loginModel.uri = newLoginURI.Text;
            loginModel.favorite = isLoginFavorite;
            loginModel.masterPswdRePrompt = rePrompt;
            loginModel.notes = newLoginNotes.Text;

            if (LoggedIn.instance.newFormType.SelectedIndex == 0 || LoggedIn.instance.newFormType.SelectedIndex == -1)
            {
                if (!string.IsNullOrEmpty(newLoginName.Text))
                {
                    if (await CreateNewItem.Login(loginModel))
                    {
                        MessageBox.Show("New Login Created");
                    }

                    else
                    {
                        MessageBox.Show("Something's wrong");
                    }
                }

                else
                {
                    MessageBox.Show("Insert Name");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
