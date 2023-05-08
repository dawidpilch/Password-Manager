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
        public static string HashPassword(string password, byte[] salt, int ittr = 10000)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, ittr))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(50));
            }
        }

        private static Random random = new Random();

        public const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345678901234567890!#%^&$*-=_+,.?/<>";

        public static string CreateSalt(int stringLength)
        {
            
            return new string(Enumerable.Repeat(chars, stringLength).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string convertQuotes(string str)
        {
            if (str.Contains("'"))
            {
                return str.Replace("'", "''");
            }

            if (str.Contains('"'))
            {
                return str.Replace('"', (char)('"' + '"'));
            }

            else
            {
                return str;
            }
        }
    }
}
