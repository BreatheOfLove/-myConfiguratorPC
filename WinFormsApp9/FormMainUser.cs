using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp9
{
    public partial class FormMainUser : Form
    {
        List<Product> _products = new List<Product>();
        string _filePathListProd = "";

        List<Product> _ShopCartProduct = new List<Product>();
        int _sumProduct = 0;

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        public FormMainUser(string userName, List<Product> products, string filePathListProd, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();
            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\sf.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;

            lblLoginUser.Text = userName;

            _products = products;
            _filePathListProd = filePathListProd;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;
        }

        private void btnOpenListProducts_Click(object sender, EventArgs e)
        {
            FormUserListProduct formUserListProduct = new FormUserListProduct(_products);
            formUserListProduct.ShowDialog();

            List<Product> selectedProducts = formUserListProduct.getShopCartProducts();
            int addedSum = formUserListProduct.getSumProducts();

            _ShopCartProduct.AddRange(selectedProducts);
            _sumProduct += addedSum;
        }

        private void btnInputShopCart_Click(object sender, EventArgs e)
        {
            FormShopCart formShopCart = new FormShopCart(_ShopCartProduct, _sumProduct, _promocodes, _filePathListPromocodes);
            formShopCart.ShowDialog();
        }
    }
}
