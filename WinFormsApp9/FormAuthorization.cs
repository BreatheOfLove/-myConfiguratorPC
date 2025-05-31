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
using System.Reflection.Emit;

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

            string jsonUsers = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(jsonUsers);
        }

        private void auth(string userName, bool isAdmin)
        {
            if (isAdmin)
            {
                MainFormAdmin myForm = new MainFormAdmin(userName, users, filePath);
                this.Hide();
                myForm.ShowDialog();
                this.Show();
            }
            else
            {
                MainFormUser myForm = new MainFormUser(userName);
                this.Hide();
                myForm.ShowDialog();
                this.Show();
            }
        }

        private void btnEnterAccount_Click(object sender, EventArgs e)
        {
            string usernameInput = txtBoxInputLogin.Text;
            string passwordInput = txtBoxInputPassword.Text;

            if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Вход")
            {
                if (authInAccount.isAuthInAccount(usernameInput, passwordInput, out bool isAdmin, ref users))
                {
                    auth(usernameInput, isAdmin);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Регистрация")
            {
                User newUser = new User(usernameInput, passwordInput, false);
                AddingUser addNewUser = new AddingUser(newUser, ref users, filePath);
            }
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
    