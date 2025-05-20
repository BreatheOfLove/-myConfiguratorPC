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
        public User(string name, string password)
        {
            _name = name;
            _password = password;
        }

        private string _name { get; }
        private string _password { get; }
    }
}
