using DataBaseProject1.Data_Base;
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

namespace DataBaseProject1.LoggedInChildForms
{
    public partial class UserDataListed : Form
    {
        private int _buttonsLocation = 30;
        public static UserDataListed instance;

        public UserDataListed()
        {
            InitializeComponent();
            instance = this;


            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                connection.Open();

                string SqlQuery = "SELECT NAME FROM [PswdManager].[dbo].[LOGINS] WHERE USER_ID = '3';";
                SqlCommand getItems = new SqlCommand(SqlQuery, connection);

                SqlDataReader reader = getItems.ExecuteReader();
                while (reader.Read())
                {
                    ListItem(reader.GetString(0), reader.GetString(0), 120, _buttonsLocation);
                    _buttonsLocation += 40;
                }

                connection.Close();
            }
        }

        public void ListItem(string buttonName, string buttonText, int x, int y)
        {
            Button button = new Button();
            button.Name = buttonName;
            Controls.Add(button);
            button.Visible = true;
            button.FlatStyle = FlatStyle.Flat;
            button.Text = buttonText;
            button.Location = new Point(x, y);
            button.Click += new EventHandler(Button_Click);
        }


        private Form activeForm;

        public void DisplayData(Form childForm, Panel panel)
        {
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

        private void Button_Click(object sender, EventArgs e)
        {
            DisplayData(new LoggedInChildForms.UserDataListed(), LoggedIn.instance.panel2);
            DisplayData(new LoggedInChildForms.NewLogin(), LoggedIn.instance.panel3);
        }
    }
}
