using DataBaseProject1.Data_Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject1.Services
{
    internal class PasswordHashing
    {
        private static Random random = new Random();
        Connections connections = new Connections();

        private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345678901234567890!#%^&$*-=_+,.?/<>";

        public string CreateSalt(int stringLength)
        {
            return new string(Enumerable.Repeat(chars, stringLength).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<string> HashPassword(string password, byte[] salt, int ittr = 10000)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, ittr))
            {
                await Task.Delay(5);                
                return Convert.ToBase64String(rfc2898.GetBytes(50));
            }
        }

        public async Task<bool> ComparePasswords(string outsidePassword, byte[] userSalt, string username)
        {
            bool result = false;
            string outsidePasswordHash = await HashPassword(outsidePassword, userSalt);

            using (SqlConnection connection = new SqlConnection(connections.ConnectionString))
            {
                string SqlQuery = "SELECT COUNT(*) PASSWORD FROM USERS WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD COLLATE SQL_Latin1_General_CP1_CS_AS;";
                SqlCommand compare = new SqlCommand(SqlQuery, connection);

                compare.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar, 100).Value = username;
                compare.Parameters.Add("@PASSWORD", System.Data.SqlDbType.NVarChar, 200).Value = outsidePasswordHash;

                try
                {
                    connection.Open();
                    string comparisonResult = compare.ExecuteScalar().ToString();

                    if (comparisonResult == "1")
                    {
                        result = true;

                        #region Design
                        SignIn.instance.passwordInfo.Visible = true;
                        SignIn.instance.outsidePassword.BackColor = Color.FromArgb(255, 255, 255);
                        SignIn.instance.outsidePassword.ForeColor = Color.FromArgb(0, 0, 0);
                        #endregion
                    }

                    #region Design
                    else
                    {
                        SignIn.instance.passwordInfo.Visible = true;
                        SignIn.instance.outsidePassword.BackColor = Color.FromArgb(192, 0, 0);
                        SignIn.instance.outsidePassword.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    #endregion
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }

            await Task.Delay(5);
            return result;
        }
    }
}
