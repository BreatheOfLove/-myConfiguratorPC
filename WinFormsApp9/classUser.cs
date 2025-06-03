using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class User
    {
        public User(string name, string password, bool isAdmin)
        {
            _name = name;
            _password = password;
            _isAdmin = isAdmin;
        }

        private string _name;
        private string _password;
        private bool _isAdmin;

        public string Name { get { return _name; } }
        public string Password { get { return _password; } }
        public bool IsAdmin { get { return _isAdmin; } }
    }
}
