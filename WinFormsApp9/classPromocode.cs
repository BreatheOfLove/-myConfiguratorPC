using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class Promocode
    {
        public Promocode(string promo, int discount)
        {
            _promo = promo;
            _discount = discount;
        }

        private string _promo;
        private int _discount;

        public string Promo { get { return _promo; } }
        public int Discount { get { return _discount; } }
    }
}
