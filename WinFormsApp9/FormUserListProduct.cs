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
        List<Product> _products;
        List<Product> _shopCartProducts = new List<Product>();
        int _sumProducts = 0;

        public List<Product> getShopCartProducts()
        {
            return _shopCartProducts;
        }

        public int getSumProducts()
        {
            return _sumProducts;
        }

        public FormUserListProduct(List<Product> products)
        {
            InitializeComponent();
            _products = products;

            foreach (var product in products)
            {
                listBoxProducts.Items.Add($"Тип: {product.Type}, название: {product.Name}, описание: {product.Description}, цена: {product.Price}");
            }
        }

        private void btnAddProdShopCart_Click(object sender, EventArgs e)
        {
            if(listBoxProducts.SelectedIndex > -1)
            {
                _shopCartProducts.Add(_products[listBoxProducts.SelectedIndex]);
                _sumProducts += _products[listBoxProducts.SelectedIndex].Price;
                MessageBox.Show("Товар добавлен");
                lblSumProducts.Text = _sumProducts.ToString();
            }
            else
            {
                MessageBox.Show("Товар не выбран");
            }
        }
    }
}
