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
            string city = comboBoxCity.SelectedItem.ToString();
            bool isAdmin = cmbBoxIsAdmin.SelectedItem.ToString() == "Администратор" ? true : false;
            if (userName != string.Empty && password != string.Empty && city != string.Empty)
            {
                User newUser = new User(userName, password, city, isAdmin);
                AddingUser.addNewUser(newUser, ref _userList, _filePath);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
