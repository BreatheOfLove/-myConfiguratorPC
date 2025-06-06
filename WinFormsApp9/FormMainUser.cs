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

        public FormMainUser(string userName, List<Product> products, string filePathListProd)
        {
            InitializeComponent();
            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\sf.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;

            lblLoginUser.Text = userName;

            _filePathListProd = filePathListProd;
            _products = products;
        }

        private void btnOpenListProducts_Click(object sender, EventArgs e)
        {
            FormUserListProduct formUserListProduct = new FormUserListProduct(_products);
            formUserListProduct.ShowDialog();
        }

    }
}
