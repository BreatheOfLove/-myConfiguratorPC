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
        string _filePath = "";
        public MainFormAdmin(string userName, List<User> users, string filePath)
        {
            InitializeComponent();
            lblLoginUser.Text = userName;
            userList = users; 
            _filePath = filePath;
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddingUserFormInAdminPanelcs addingUserFormInAdminPanelcs = new AddingUserFormInAdminPanelcs(userList, _filePath);
            addingUserFormInAdminPanelcs.Show(); 
        }
    }
}
