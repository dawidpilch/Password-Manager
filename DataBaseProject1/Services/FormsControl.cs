using DataBaseProject1.LoggedInChildForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject1.Services
{
    internal static class FormsControl
    {
        //Use to prevent stacking of <newItem> forms
        public static void CloseForms()
        {
            var newLogin = Application.OpenForms.OfType<NewLogin>().FirstOrDefault();
            var newCard = Application.OpenForms.OfType<NewCard>().FirstOrDefault();
            var newId = Application.OpenForms.OfType<NewIdentity>().FirstOrDefault();

            if (newLogin != null)
            {
                newLogin.Close();
            }

            if (newCard != null)
            {
                newCard.Close();
            }

            if (newId != null)
            {
                newId.Close();
            }
        }

        //Open UserDataListed Form
        public static void OpenUserDataListed()
        {
            var dataListedForm = Application.OpenForms.OfType<UserDataListed>().FirstOrDefault();

            if (dataListedForm != null)
            {
                dataListedForm.Close();
            }

            UserDataListed childForm = new UserDataListed();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Location = new Point(15, 15);
            LoggedIn.instance.panel2.Controls.Add(childForm);
            LoggedIn.instance.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
