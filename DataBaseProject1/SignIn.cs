using System;
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
                                      
    // -> New Login Form based on Unique Usernames and Hashed Passwords



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
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JBI31J2;Initial Catalog=DataBaseProject1;Integrated Security=True;"))
            {
                //SqlDataAdapter da = new SqlDataAdapter
                //    ("Select Count(*) From USERS where USERNAME='" + outsideUsername.Text + "' and PASSWORD ='"
                //    + outsidePassword.Text + "'", conn);

                //DataTable dataTable = new DataTable();
                //da.Fill(dataTable);

                //if (dataTable.Rows[0][0].ToString() == "1")
                //{
                //    this.Hide();
                //    LoggedIn loggedIn = new LoggedIn();
                //    loggedIn.Show();
                //}

                //else
                //{
                //    MessageBox.Show("Wrong username or password!");
                //}
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
