using DataBaseProject1.Data_Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject1.Services
{
    internal class User
    {
        Connections connections = new Connections();
        PasswordHashing passwordHashing = new PasswordHashing();

        public async Task<bool> Login(string username, string password)
        {
            bool loginSuccessful = false;
            
            if (!await DoesUserExist(username))
            {
                return loginSuccessful;
            }

            string loginQuery = "SELECT PASSWORDSALT FROM USERS WHERE USERNAME = @USERNAME COLLATE SQL_Latin1_General_CP1_CS_AS;";

            using (SqlConnection connection = new SqlConnection(connections.ConnectionString))
            {
                
                SqlCommand getUserSalt = new SqlCommand(loginQuery, connection);

                getUserSalt.Parameters.Add("@USERNAME", System.Data.SqlDbType.NVarChar, 50).Value = username;

                try
                {
                    connection.Open();
                    string getUserSaltResult = getUserSalt.ExecuteScalar().ToString();

                    byte[] getUserSaltResultBytes = Encoding.ASCII.GetBytes(getUserSaltResult);

                    if (await passwordHashing.ComparePasswords(password, getUserSaltResultBytes, username))
                    {
                        loginSuccessful = true;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }

            return loginSuccessful;
        }

        public async Task<bool> DoesUserExist(string username)
        {
            bool result = false;

            string doesExistQuery = "SELECT COUNT(*) USERNAME FROM USERS WHERE USERNAME = @USERNAME COLLATE SQL_Latin1_General_CP1_CS_AS;";

            using (SqlConnection connection = new SqlConnection(connections.ConnectionString))
            {
                SqlCommand doesExist = new SqlCommand(doesExistQuery, connection);

                doesExist.Parameters.Add("@USERNAME", System.Data.SqlDbType.NVarChar, 50).Value = username;

                try
                {
                    connection.Open();
                    string queryResult = doesExist.ExecuteScalar().ToString();

                    if (queryResult == "1")
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
