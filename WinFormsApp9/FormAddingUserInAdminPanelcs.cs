using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class FormAddingUserInAdminPanelcs : Form
    {
        List<User> _userList = new List<User>();
        string _filePath = "";

        public FormAddingUserInAdminPanelcs(List<User> users, string filePath)
        {
            InitializeComponent();
            _userList = users;
            _filePath = filePath;
        }

        private void btnAddingUser_Click(object sender, EventArgs e)
        {
            string userName = txtBoxInputLogin.Text;
            string password = txtBoxInputPassword.Text;
            bool isAdmin = cmbBoxIsAdmin.SelectedItem.ToString() == "Администратор" ? true : false;

            User newUser = new User(userName, password, isAdmin);

            AddingUser addingUser = new AddingUser(newUser, ref _userList, _filePath);
        }
    }
}
