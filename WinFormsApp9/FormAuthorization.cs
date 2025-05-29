using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Encodings.Web;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp9
{
    public partial class FormAuthorization : Form
    {
        static string filePath = @"C:\Users\New\Desktop\base.json";
        List<User> users = new List<User>();

        public FormAuthorization()
        {
            InitializeComponent();
            cmbBoxSelectionAuthorization.SelectedIndex = 0;

            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(json);
        }

        private void auth(string userName, bool isAdmin)
        {
            if (isAdmin) { MainFormAdmin adminForm = new MainFormAdmin(userName); adminForm.ShowDialog(); }
            else { MainFormUser userForm = new MainFormUser(userName); userForm.ShowDialog(); }
            this.Hide();
            this.Close();
        }
    
        private bool authInAccount(string usernameInput, string passwordInput, out bool isAdmin)
        {
            isAdmin = false;
            foreach(User user in users)
            {
                if (usernameInput == user.Name && passwordInput == user.Password)
                {
                    isAdmin = user.IsAdmin;
                    return true;
                }
            }
            return false;
        }

        private void btnEnterAccount_Click(object sender, EventArgs e)
        {
            string usernameInput = txtBoxInputLogin.Text;
            string passwordInput = txtBoxInputPassword.Text;

            if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Вход")
            {
                if(authInAccount(usernameInput, passwordInput, out bool isAdmin))
                {
                    auth(usernameInput, isAdmin);
                }
            }
            else if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Регистрация")
            {
                if (checkLogin.loginIsHave(usernameInput) && checkPassword.passwordIsLength(passwordInput))
                {
                    User newUser = new User(usernameInput, passwordInput, false);
                    AddingUser addNewUser = new AddingUser(newUser, filePath, ref users);
                }
                else
                {
                    MessageBox.Show("Логин или пароль не подходят по длине");
                }
            }
        }
    }
}
    