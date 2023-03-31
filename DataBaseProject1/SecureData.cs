using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject1
{
    internal class SecureData
    {
        public static string HashPassword(string passoword, byte[] salt, int ittr = 10000)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(passoword, salt, ittr))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(20));
            }
        }


        private static Random random = new Random();

        public static string CreateSalt(int stringLength)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345678901234567890!#%^&$*-=_+,.?/<>";
            return new string(Enumerable.Repeat(chars, stringLength).Select(s => s[random.Next(s.Length)]).ToArray());
        }


        




        //public static string EncryptData(string unsecuredData) 
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();

        //    byte[] passwordHash = Encoding.UTF8.GetBytes(unsecuredData);

        //    return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        //}




        //public static string HashPassword(string passoword, int ittr = 10000)
        //{
        //    byte[] salt = new byte[24];
        //    new RNGCryptoServiceProvider().GetBytes(salt);
        //    var rfc2898 = new Rfc2898DeriveBytes(passoword, salt, ittr);
        //    byte[] hash = rfc2898.GetBytes(24);

        //    return Convert.ToBase64String(hash);
        //}



        //public static string GenerateSaltedHash(byte[] plainText, byte[] salt)
        //{
        //    HashAlgorithm algorithm = new SHA256Managed();

        //    byte[] plainTextWithSaltBytes =
        //      new byte[plainText.Length + salt.Length];

        //    for (int i = 0; i < plainText.Length; i++)
        //    {
        //        plainTextWithSaltBytes[i] = plainText[i];
        //    }
        //    for (int i = 0; i < salt.Length; i++)
        //    {
        //        plainTextWithSaltBytes[plainText.Length + i] = salt[i];
        //    }

        //    return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        //}




        //new RNGCryptoServiceProvider().GetBytes(salt);
        //byte[] passwordByte = Encoding.ASCII.GetBytes(passwordRegister.Text);


        //byte[] testHash = SecureData.HashPassword(passwordByte, salt, 1000).ToString();
    }
}
