using DataBaseProject1.Data_Base;
using DataBaseProject1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataBaseProject1.Services
{
    internal class CreateNewItem
    {
        public static async Task<bool> Login(NewLoginModel loginModel)
        {
            bool isSuccessful = false;

            using (SqlConnection conn = new SqlConnection(Connections.ConnectionString))
            {
                string SqlQuery = "INSERT INTO LOGINS (USER_ID, NAME, USERNAME, PASSWORD," +
                    "AUTHENTICATOR_KEY, URI, FAVORITE, MASTER_PSWD_RE_PROMPT, NOTES) VALUES " +
                    "(@USER_ID, @NAME, @USERNAME, @PASSWORD, @AUTHENTICATOR_KEY, @URI, @FAVORITE, @MASTER_PSWD_RE_PROMPT, @NOTES);";
                conn.Open();

                SqlCommand command = new SqlCommand(SqlQuery, conn);

                command.Parameters.Add("@USER_ID", SqlDbType.Int, 50).Value = loginModel.userId;
                command.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = loginModel.name;
                command.Parameters.Add("@USERNAME", SqlDbType.NVarChar, 50).Value = loginModel.username;
                command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar, 50).Value = loginModel.password;
                command.Parameters.Add("@AUTHENTICATOR_KEY", SqlDbType.NVarChar, 50).Value = loginModel.authenticatorKey;
                command.Parameters.Add("@URI", SqlDbType.NVarChar, 50).Value = loginModel.uri;
                command.Parameters.Add("@FAVORITE", SqlDbType.Bit).Value = loginModel.favorite;
                command.Parameters.Add("@MASTER_PSWD_RE_PROMPT", SqlDbType.Bit).Value = loginModel.masterPswdRePrompt;
                command.Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = loginModel.notes;



                if (command.ExecuteNonQuery() != 0)
                {
                    isSuccessful = true;
                    MessageBox.Show("Success!");
                }

                else
                {
                    MessageBox.Show("nie działa");
                }

                conn.Close();
                await Task.Delay(10);
                return isSuccessful;
            }
        }
    }
}
