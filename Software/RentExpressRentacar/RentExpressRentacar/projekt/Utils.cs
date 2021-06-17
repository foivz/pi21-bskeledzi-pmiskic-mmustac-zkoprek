using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace projekt
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();


            byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static string DefaultHashedPassword()
        {
            SHA256 sha256 = SHA256.Create();


            byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
