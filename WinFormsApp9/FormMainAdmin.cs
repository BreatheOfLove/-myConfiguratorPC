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

        List<Accessories> _accessories = new List<Accessories>();
        string _filePathListAccessories = "";

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        public FormMainAdmin(User user, string weather, List<User> users, string filePathListUsers, List<Accessories> accessories, string filePathListAccessories, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();

            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\arle.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;

            lblLoginUser.Text = user.Name;
            _users = users;
            _filePathListUsers = filePathListUsers;

            _accessories = accessories;
            _filePathListAccessories = filePathListAccessories;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;

            lblTextWeaher.Text = $"В {user.City} сейчас {weather}°";
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FormAddingUserInAdminPanelcs addingUserFormInAdminPanelcs = new FormAddingUserInAdminPanelcs(_users, _filePathListUsers);
            addingUserFormInAdminPanelcs.Show();
        }

        private void btnAddAccessories_Click(object sender, EventArgs e)
        {
            FormAddAccessories formAddAccessories = new FormAddAccessories(_accessories, _filePathListAccessories);
            formAddAccessories.Show();
        }

        private void btnAddNewPromocode_Click(object sender, EventArgs e)
        {
            FormAddPromocode formAddPromocode = new FormAddPromocode(_promocodes, _filePathListPromocodes);
            formAddPromocode.Show();
        }
    }
}
