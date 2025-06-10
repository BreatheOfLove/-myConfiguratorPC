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
    public partial class FormMainAdmin : Form
    {
        List<User> _users = new List<User>();
        string _filePathListUsers = "";

        List<Product> _products = new List<Product>();
        string _filePathListProd = "";

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        public FormMainAdmin(string userName, List<User> users, string filePathListUsers, List<Product> products, string filePathListProd, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();

            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\arle.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;

            lblLoginUser.Text = userName;
            _users = users;
            _filePathListUsers = filePathListUsers;

            _products = products;
            _filePathListProd = filePathListProd;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FormAddingUserInAdminPanelcs addingUserFormInAdminPanelcs = new FormAddingUserInAdminPanelcs(_users, _filePathListUsers);
            addingUserFormInAdminPanelcs.Show();
        }

        private void btnAddAccessories_Click(object sender, EventArgs e)
        {
            FormAddAccessories formAddAccessories = new FormAddAccessories(_products, _filePathListProd);
            formAddAccessories.Show();
        }

        private void btnAddNewPromocode_Click(object sender, EventArgs e)
        {
            FormAddPromocode formAddPromocode = new FormAddPromocode(_promocodes, _filePathListPromocodes);
            formAddPromocode.Show();
        }
    }
}
