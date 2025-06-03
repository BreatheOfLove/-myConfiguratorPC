using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class Product
    {
        public Product(string name, string description, string price) 
        {
            _name = name;
            _description = description;
            _price = price;
        }

        private string _name;
        private string _description;
        private string _price;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public string Price { get { return _price; } }
    }
}
