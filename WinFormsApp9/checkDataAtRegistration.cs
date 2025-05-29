using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    internal static class checkLogin
    {
        public static bool loginIsHave(string login)
        {
            return login.Length > 0;
        }
    }

    internal static class checkPassword
    {
        public static bool passwordIsLength(string password)
        {
            return password.Length > 0 && password.Length <= 15;
        }
    }
}
