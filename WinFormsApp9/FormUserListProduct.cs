using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class FormUserListProduct : Form
    {
        List<Accessories> _acessories;
        List<Accessories> _shopCartAcessories = new List<Accessories>();
        int _sumAcessories = 0;

        public List<Accessories> getShopCartProducts()
        {
            return _shopCartAcessories;
        }

        public int getSumProducts()
        {
            return _sumAcessories;
        }

        public FormUserListProduct(List<Accessories> accessories)
        {
            InitializeComponent();
            _acessories = accessories;

            foreach (var accessorie in accessories)
            {
                listBoxProducts.Items.Add($"Тип: {accessorie.Type}, название: {accessorie.Name}, описание: {accessorie.Description}, цена: {accessorie.Price}");
            }
        }

        private void btnAddProdShopCart_Click(object sender, EventArgs e)
        {
            if(listBoxProducts.SelectedIndex > -1)
            {
                _shopCartAcessories.Add(_acessories[listBoxProducts.SelectedIndex]);
                _sumAcessories += _acessories[listBoxProducts.SelectedIndex].Price;
                MessageBox.Show("Товар добавлен");
                lblSumProducts.Text = _sumAcessories.ToString();
            }
            else
            {
                MessageBox.Show("Товар не выбран");
            }
        }
    }
}
