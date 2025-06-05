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
        public FormUserListProduct(List<Product> products)
        {
            InitializeComponent();
            _products = products;
            foreach (var product in _products)
            {
                listBoxProducts.Items.Add($"Тип: {product.Type}, название: {product.Name}, описание: {product.Description}, цена: {product.Price}");
            }
        }

        private void FormUserListProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProdShopCart_Click(object sender, EventArgs e)
        {

        }
    }
}
