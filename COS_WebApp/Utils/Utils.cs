using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COS_DesktopApp.Utils
{
    class Utils
    {
        public static string GetHash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            
            // compute the hash from the plain text 
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            // get hash result of the plain text
            byte[] result = md5.Hash;
            StringBuilder stringBuilder = new StringBuilder();

            // append result bytes to string
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
