 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp9
{
    internal class authInAccount
    {
        static public bool isAuthInAccount(string userName, string userPassword, out bool isAdmin, ref List<User> users)
        {
            isAdmin = false;
            foreach (User user in users)
            {
                if (userName == user.Name && userPassword == user.Password)
                {
                    isAdmin = user.IsAdmin;
                    return true;
                }
            }
            return false;
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
