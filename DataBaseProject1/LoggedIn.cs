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

namespace DataBaseProject1
{
    public partial class LoggedIn : Form
    {
        private Button currentButton;
        private string CurrentUserID;
        private bool PlusButtonClickable = true;



        public LoggedIn()
        {
            InitializeComponent();
            //INSERT INTO[DataBaseProject1].[dbo].[USERS_LOGINS]
            //(USER_ID, LOGIN_NAME, LOGIN_USERNAME, LOGIN_PASSWORD)
            //VALUES(3, 'TikTok', 'GrzejnikTikTok', 'węxżą231');
            //comboBox1.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand getUserID = new SqlCommand
                    ("SELECT [ID] FROM [DataBaseProject1].[dbo].[USERS] WHERE [USERNAME] = '" 
                    + SignIn.Username + "' COLLATE SQL_Latin1_General_CP1_CS_AS", conn);
                CurrentUserID = getUserID.ExecuteScalar().ToString();
                conn.Close();
            }
        }


        #region LoginTab

        private void loginTab_Click(object sender, EventArgs e)
        {
            OpenItemsListChildForm(sender);
        }
        #endregion


        #region CardTab

        private void cardTab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        #endregion


        #region IdentificationTab
        private void identityTab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        #endregion

        private void ActivateButton(object btnSender)
        {
            DisableButton();
            currentButton = (Button)btnSender;
            currentButton.BackColor = Color.White;
            currentButton.ForeColor = Color.FromArgb(0, 204, 103);
                
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(240, 240, 240);
                    previousBtn.ForeColor = Color.FromArgb(107, 107, 107);
                }
            }
        }

        private Form activeForm;
        private void OpenItemsListChildForm(object btnSender)
        {

            ActivateButton(btnSender);
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand loginsCount = new SqlCommand("Select COUNT(*) [LOGINS_ID] FROM [DataBaseProject1].[dbo].[USERS_LOGINS] WHERE [USER_ID] = '" + CurrentUserID + "'", conn);
                string loginsCountResult = loginsCount.ExecuteScalar().ToString();
                conn.Close();

                if (loginsCountResult != "0")
                {

                }

                else
                {
                    addNewLogin.Visible = true;
                    emptyLoginList.Visible = true;
                }
            }
        }

        private void OpenCreatingNewForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point(15, 15);
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void addNewLogin_Click(object sender, EventArgs e)
        {
            if (PlusButtonClickable == true)
            {
                OpenCreatingNewForm(new LoggedInChildForms.NewLogin(), sender);
                PlusButtonClickable = false;
            }
        }
    }
}
