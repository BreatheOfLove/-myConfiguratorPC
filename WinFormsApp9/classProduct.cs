using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;

namespace WinFormsApp9
{
    public class Product
    {
        public Product(string type, string name, string description, int price) 
        {
            _type = type;
            _name = name;
            _description = description;
            _price = price;
        }

        private string _type;
        private string _name;
        private string _description;
        private int _price;

        public string Type { get { return _type; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Price { get { return _price; } }
    }
}
