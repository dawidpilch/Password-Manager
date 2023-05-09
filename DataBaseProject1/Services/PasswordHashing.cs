using DataBaseProject1.Data_Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string SqlQuery = "SELECT COUNT(*) PASSWORD FROM USERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD COLLATE SQL_Latin1_General_CP1_CS_AS;";
                SqlCommand compare = new SqlCommand(SqlQuery, connection);

                compare.Parameters.Add("@USERNAME", System.Data.SqlDbType.NVarChar, 50).Value = username;
                compare.Parameters.Add("@PASSWORD", System.Data.SqlDbType.NVarChar, 200).Value = outsidePasswordHash;

                try
                {
                    connection.Open();
                    string comparisonResult = compare.ExecuteScalar().ToString();
                    System.Windows.Forms.MessageBox.Show(comparisonResult);

                    if (comparisonResult == "1")
                    {
                        result = true;
                    }
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
