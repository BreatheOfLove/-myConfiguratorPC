using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace WinFormsApp9
{
    // Password hashing class 
    internal class hashPass
    {

        public static string GetHashSHA256(string plainText)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(plainText);
                byte[] result = hash.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder(result.Length * 2);

                foreach (byte b in result)
                {
                    builder.Append(b.ToString("X2"));
                }

                return builder.ToString();
            }
        }
    }

    internal class authInAccount
    {
        public static User isAuthInAccount(string userName, string userPassword, ref List<User> users)
        {
            foreach (User user in users)
            {
                if (userName == user.Name && user.PasswordHash == hashPass.GetHashSHA256(userPassword))
                {
                    return user;
                }
            }
            return null;
        }
    }

    internal class userHaveInBase 
    {
        static public bool userHaveInJSON(string usernameInput, ref List<User> users)
        {
            foreach (User user in users)
            {
                if (usernameInput == user.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
