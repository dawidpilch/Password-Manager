using DataBaseProject1.LoggedInChildForms;
using System;
using System.Collections.Generic;
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
    }
}
