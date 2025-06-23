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
        public User(string name, string passwordHash, string city, bool isAdmin, List<Accessories> purchases)
        {
            _name = name;
            _passwordHash = passwordHash;
            _city = city;
            _isAdmin = isAdmin;
            _purchases = purchases;
        }

        private string _name;
        private string _passwordHash;
        private string _city;

        private bool _isAdmin;

        private List<Accessories> _purchases;

        public string Name { get { return _name; } }
        public string PasswordHash { get { return _passwordHash; } }
        public string City { get { return _city; } }

        public bool IsAdmin { get { return _isAdmin; } }

        public List<Accessories> Purchases { get { return _purchases; } }
    }
}
