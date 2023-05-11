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

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoggedIn.instance.newFormType.SelectedIndex == 0 || LoggedIn.instance.newFormType.SelectedIndex == -1)
            {
                if (!string.IsNullOrEmpty(newLoginName.Text))
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
                    {
                        //conn.Open();
                        //SqlCommand newLoginToDatabase = new SqlCommand
                        //    ("INSERT INTO [DataBaseProject1].[dbo].[USERS_LOGINS] ([USER_ID], [LOGIN_NAME], [LOGIN_USERNAME], [LOGIN_PASSWORD], " +
                        //    "[LOGIN_AUTHENTICATOR_KEY], [LOGIN_URI], [LOGIN_FAVORITE], [LOGIN_REPROMPT], [LOGIN_NOTES]) VALUES ('" +

                        //    //USER_ID
                        //    LoggedIn.instance.CurrentUserID + "', '" +

                        //    //LOGIN_NAME
                        //    secureData.convertQuotes(newLoginName.Text) + "', '" +

                        //    //LOGIN_USERNAME
                        //    secureData.convertQuotes(newLoginUsername.Text) + "', '" +

                        //    //LOGIN_PASSWORD
                        //    secureData.convertQuotes(newLoginPassword.Text) + "', '" +

                        //    //LOGIN_AUTHENTICATOR_KEY
                        //    secureData.convertQuotes(newLoginTOTP.Text) + "', '" +

                        //    //LOGIN_URI
                        //    secureData.convertQuotes(newLoginURI.Text) + "', '" +

                        //    //LOGIN_FAVORITE
                        //    @isLoginFavorite + "', '" +

                        //    //LOGIN_REPROMPT
                        //    @rePrompt + "', '" +

                        //    //LOGIN_NOTES
                        //    secureData.convertQuotes(newLoginNotes.Text) + "');", conn);

                        //string newLoginToDatabaseResult = newLoginToDatabase.ExecuteNonQuery().ToString();
                        //conn.Close();

                        //if (newLoginToDatabaseResult != "0")
                        //{
                        //    MessageBox.Show("Success!");
                        //}

                        //else
                        //{
                        //    MessageBox.Show("Zjebałeś coś");
                        //}
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
