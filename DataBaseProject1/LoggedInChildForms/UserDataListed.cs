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
        private int _numberOfItems = 4;
        private int _buttonsLocation = 30;
        public static UserDataListed instance;

        public UserDataListed()
        {
            InitializeComponent();
            instance = this;

            LoggedIn loggedIn = new LoggedIn();
            


            int y = 1;
            //for (int i = 0; i <= _numberOfItems; i++)
            //{
            //    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
            //    {
            //        conn.Open();
            //        SqlCommand getItemName = new SqlCommand
            //            ("SELECT [LOGIN_NAME] FROM (SELECT ROW_NUMBER() OVER( ORDER BY[LOGIN_NAME])[ROW_NUMBER], [LOGIN_NAME] " +
            //            "FROM[DataBaseProject1].[dbo].[USERS_LOGINS] WHERE [USER_ID] = " + loggedIn.CurrentUserID +
            //            ") AS SUBQUERY WHERE [ROW_NUMBER] = " + y + ";", conn);


            //        string getItemNameResult = getItemName.ExecuteScalar().ToString();
            //        conn.Close();

            //        if (getItemNameResult != "0")
            //        {
            //            ListItem(getItemNameResult, getItemNameResult, 120, _buttonsLocation);
            //            _buttonsLocation += 40;
            //            y++;
            //        }

            //        else
            //        {
            //            MessageBox.Show(";(");
            //        }
            //    }
            //}
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

        private void Button_Click(object sender, EventArgs e)
        {
            LoggedIn.instance.OpenCreatingNewForm(new LoggedInChildForms.NewLogin(), LoggedIn.instance.panel3);
        }
    }
}
