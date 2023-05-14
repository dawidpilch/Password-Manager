using DataBaseProject1.Data_Base;
using DataBaseProject1.LoggedInChildForms;
using DataBaseProject1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataBaseProject1
{
    public partial class LoggedIn : Form
    {
        private Button currentButton;
        public static int userID;
        public static LoggedIn instance;

        public LoggedIn()
        {
            InitializeComponent();
            instance = this;
            addNewLogin.Visible = true;
            newFormHeader.BorderStyle = BorderStyle.None;
            typeLabel.Visible = false;
            newFormType.Visible = false;
            userID = User.GetUserID(SignIn.Email).Result;
            MessageBox.Show(userID.ToString());
        }


        #region Activate buttons
        private void loginTab_Click(object sender, EventArgs e)
        {
            OpenItemsListChildForm(sender);
        }

        private void cardTab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

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

        private void OpenItemsListChildForm(object btnSender)
        {
            ActivateButton(btnSender);
            using (SqlConnection conn = new SqlConnection(Connections.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select COUNT(*) ID FROM LOGINS WHERE USER_ID = @USER_ID", conn);
                command.Parameters.Add("@USER_ID", SqlDbType.NVarChar, 50).Value = userID;
                string loginsCountResult = command.ExecuteScalar().ToString();
                conn.Close();

                if (loginsCountResult != "0")
                {
                    OpenCreatingNewForm(new UserDataListed(), panel2);
                }

                else
                {
                    emptyLoginList.Visible = true;
                }
            }
        }

        private Form activeForm;
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

        //Clicking the Plus Button
        private void addNewLogin_Click(object sender, EventArgs e)
        {
                OpenCreatingNewForm(new LoggedInChildForms.NewLogin(), panel3);
                newFormType.SelectedIndex = 0;
                newFormHeader.BorderStyle = BorderStyle.FixedSingle;
                typeLabel.Visible = true;
                newFormType.Visible = true;
        }

        //Selecting type of new item
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
