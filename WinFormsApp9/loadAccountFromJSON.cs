using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class User
    {
        public User(string name, string password, string role)
        {
            _name = name;
            _password = password;
            _role = role;
        }

        private string _name { get; }
        private string _password { get; }
        private string _role { get; }
    }
}
