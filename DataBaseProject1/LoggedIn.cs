using DataBaseProject1.Data_Base;
using DataBaseProject1.LoggedInChildForms;
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
        public string CurrentUserID;
        public static LoggedIn instance;

        Connections connections = new Connections();

        public LoggedIn()
        {
            InitializeComponent();
            instance = this;
            addNewLogin.Visible = true;
            

            using (SqlConnection conn = new SqlConnection(connections.ConnectionString))
            {
                conn.Open();
                SqlCommand getUserID = new SqlCommand
                    ("SELECT ID FROM USERS WHERE EMAIL = '" 
                    + SignIn.Email + "' COLLATE SQL_Latin1_General_CP1_CS_AS", conn);
                CurrentUserID = getUserID.ExecuteScalar().ToString();
                conn.Close();
            }

            newFormHeader.BorderStyle = BorderStyle.None;
            typeLabel.Visible = false;
            newFormType.Visible = false;
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
            using (SqlConnection conn = new SqlConnection(connections.ConnectionString))
            {
                //conn.Open();
                //SqlCommand loginsCount = new SqlCommand("Select COUNT(*) LOGINS_ID FROM USERS_LOGINS WHERE USER_ID = '" + CurrentUserID + "'", conn);
                //string loginsCountResult = loginsCount.ExecuteScalar().ToString();
                //conn.Close();

                //if (loginsCountResult != "0")
                //{
                //    OpenCreatingNewForm(new LoggedInChildForms.UserDataListed(), panel2);
                //}

                //else
                //{
                //    emptyLoginList.Visible = true;
                //}
            }
        }

        public void OpenCreatingNewForm(Form childForm, Panel panel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Location = new Point(15, 15);
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void addNewLogin_Click(object sender, EventArgs e)
        {
                OpenCreatingNewForm(new LoggedInChildForms.NewLogin(), panel3);
                newFormType.SelectedIndex = 0;
                newFormHeader.BorderStyle = BorderStyle.FixedSingle;
                typeLabel.Visible = true;
                newFormType.Visible = true;
        }

        private void newFormType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newFormType.SelectedIndex == 0)
            {
                OpenCreatingNewForm(new LoggedInChildForms.NewLogin(), panel3);
            }

            else if (newFormType.SelectedIndex == 1)
            {
                OpenCreatingNewForm(new LoggedInChildForms.NewCard(), panel3);
            }

            else if (newFormType.SelectedIndex == 2)
            {
                OpenCreatingNewForm(new LoggedInChildForms.NewIdentity(), panel3);
            }
        }
    }
}
