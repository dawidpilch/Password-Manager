﻿using DataBaseProject1.Data_Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject1.Services
{
    internal class User
    {
        //Logging In to the app
        public static async Task<bool> Login(string email, string password)
        {
            bool loginSuccessful = false;
                        
            if (!await DoesUserExist(email))
            {
                return loginSuccessful;
            }

            string loginQuery = "SELECT PASSWORDSALT FROM USERS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                
                SqlCommand getUserSalt = new SqlCommand(loginQuery, connection);

                getUserSalt.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar, 100).Value = email;

                try
                {
                    connection.Open();
                    string getUserSaltResult = getUserSalt.ExecuteScalar().ToString();

                    byte[] getUserSaltResultBytes = Encoding.ASCII.GetBytes(getUserSaltResult);

                    if (await PasswordHashing.ComparePasswords(password, getUserSaltResultBytes, email))
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


        //Checking if the provided email exists in database
        public static async Task<bool> DoesUserExist(string email)
        {
            bool result = false;

            string doesExistQuery = "SELECT COUNT(*) EMAIL FROM USERS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                SqlCommand doesExist = new SqlCommand(doesExistQuery, connection);

                doesExist.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar, 100).Value = email;

                try
                {
                    connection.Open();

                    string queryResult = doesExist.ExecuteScalar().ToString();

                    connection.Close();

                    if (queryResult == "1")
                    {
                        result = true;
                        #region Design
                        SignIn.instance.usernameInfo.Visible = false;
                        SignIn.instance.outsideUsername.BackColor = Color.FromArgb(255, 255, 255);
                        SignIn.instance.outsideUsername.ForeColor = Color.FromArgb(0, 0, 0);
                        #endregion
                    }

                    #region Design
                    else
                    {
                        SignIn.instance.usernameInfo.Visible = true;
                        SignIn.instance.outsideUsername.BackColor = Color.FromArgb(192, 0, 0);
                        SignIn.instance.outsideUsername.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    #endregion
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            await Task.Delay(5);
            return result; 
        }


        //Registration - Creating a new account
        public static async Task<bool> CreateNewAccount(string password, string email, string phoneNumber)
        {
            bool registerSuccessful = false;

            if (!await IsEmailAvailable(email))
            {
                return false;
            }

            string SqlQuery = "INSERT INTO USERS (EMAIL, PASSWORD, PHONENUMBER, DATE, PASSWORDSALT) VALUES " +
                "(@EMAIL, @PASSWORD, @PHONENUMBER, @DATE, @PASSWORDSALT)";

            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                SqlCommand command = new SqlCommand(SqlQuery, connection);

                string passwordSalt = PasswordHashing.CreateSalt(8);
                byte[] passwordSaltByte = Encoding.ASCII.GetBytes(passwordSalt);

                command.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar, 50).Value = email.ToLower();
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.NVarChar, 200).Value = await PasswordHashing.HashPassword(password, passwordSaltByte);
                command.Parameters.Add("@PHONENUMBER", System.Data.SqlDbType.NVarChar, 15).Value = phoneNumber;
                command.Parameters.Add("@DATE", System.Data.SqlDbType.Date).Value = DateTime.UtcNow.ToString("yyyy-MM-dd");
                command.Parameters.Add("@PASSWORDSALT", System.Data.SqlDbType.NVarChar, 8).Value = passwordSalt;

                try
                {
                    connection.Open();
                    
                    string commandResult = command.ExecuteNonQuery().ToString();
                    
                    connection.Close();

                    if (commandResult != "0")
                    {
                        registerSuccessful = true;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
                return registerSuccessful;
            }
        }


        //Check if Email is already assigned to Existing Account
        public static async Task<bool> IsEmailAvailable(string email)
        {
            bool emailAvailable = false;

            string SqlQuery = "SELECT COUNT(*) FROM USERS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                SqlCommand command = new SqlCommand(SqlQuery, connection);

                command.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 50).Value = email;

                try
                {
                    connection.Open();
                    
                    string reader = command.ExecuteScalar().ToString();

                    connection.Close();
                    
                    if (reader == "0")
                    {
                        emailAvailable = true;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            await Task.Delay(5);
            return emailAvailable;
        }


        //Get User ID
        public static async Task<int> GetUserID(string email)
        {
            int userID = 0;

            string SqlQuery = "SELECT ID FROM USERS WHERE EMAIL = @EMAIL";

            using (SqlConnection connection = new SqlConnection(Connections.ConnectionString))
            {
                SqlCommand getUserID = new SqlCommand(SqlQuery, connection);

                getUserID.Parameters.Add("@EMAIL", System.Data.SqlDbType.NVarChar, 50).Value = email;

                try
                {
                    connection.Open();

                    return (int)getUserID.ExecuteScalar();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }

            await Task.Delay(5);
            return userID;
        }
    }
}
