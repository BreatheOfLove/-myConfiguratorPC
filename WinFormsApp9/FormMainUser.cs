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
        string _filePathListUsers = "";
        List<User> _users = new List<User>();

        List<Accessories> _accessories = new List<Accessories>();
        string _filePathListProd = "";

        List<Accessories> _ShopCartProduct = new List<Accessories>();
        int _sumProduct = 0;

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        User _user;

        public FormMainUser(User user,List<User> users, string filePathListUsers, string weather, List<Accessories> products, string filePathListProd, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();
            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\yae.jpg");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;

            lblLoginUser.Text = user.Name;

            _user = user;

            _users = users;
            _filePathListUsers = filePathListUsers;

            _accessories = products;
            _filePathListProd = filePathListProd;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;


            lblTextWeaher.Text = $"В {user.City} сейчас {weather}°";
        }

        private void btnOpenListProducts_Click(object sender, EventArgs e)
        {
            FormUserListProduct formUserListProduct = new FormUserListProduct(_accessories);
            formUserListProduct.ShowDialog();

            List<Accessories> selectedAccessories = formUserListProduct.getShopCartProducts();
            int addedSum = formUserListProduct.getSumProducts();

            _ShopCartProduct.AddRange(selectedAccessories);
            _sumProduct += addedSum;
        }

        private void btnInputShopCart_Click(object sender, EventArgs e)
        {
            FormShopCart formShopCart = new FormShopCart(_user,_users, _filePathListUsers , _ShopCartProduct, _sumProduct, _promocodes, _filePathListPromocodes);
            formShopCart.ShowDialog();

            _sumProduct = formShopCart.getSumShopCarts();
        }

        private void btnOpenListPurchaseHistory_Click(object sender, EventArgs e)
        {
            FormPurchaseHistory formPurchaseHistory = new FormPurchaseHistory(_user.Purchases);
            formPurchaseHistory.ShowDialog();
        }
    }
}
