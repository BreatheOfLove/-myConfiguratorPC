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
    public partial class MainFormAdmin : Form
    {
        List<User> userList = new List<User>();
        string _filePathListUsers = "";
        string _filePathListProd = "";

        public MainFormAdmin(string userName, List<User> users, string filePathListUsers, string filePathListProd)
        {
            InitializeComponent();
            lblLoginUser.Text = userName;
            userList = users;
            _filePathListUsers = filePathListUsers;
            _filePathListProd = filePathListProd;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddingUserFormInAdminPanelcs addingUserFormInAdminPanelcs = new AddingUserFormInAdminPanelcs(userList, _filePathListUsers);
            addingUserFormInAdminPanelcs.Show();
        }

        private void btnAddAccessories_Click(object sender, EventArgs e)
        {
            FormAddAccessories formAddAccessories = new FormAddAccessories(_filePathListProd);
            formAddAccessories.Show();
        }
    }
}
