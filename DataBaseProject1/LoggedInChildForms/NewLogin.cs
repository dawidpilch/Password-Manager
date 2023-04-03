using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject1.LoggedInChildForms
{
    public partial class NewLogin : Form
    {
        public NewLogin()
        {
            InitializeComponent();
            newLoginType.SelectedIndex = 0;
        }

        private void newLoginType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newLoginType.SelectedIndex == 0)
            {

            }

            else if (newLoginType.SelectedIndex == 1)
            {
                MessageBox.Show("card");
            }

            else if (newLoginType.SelectedIndex == 2)
            {

            }
        }
    }
}
