﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinFormsApp9
{
    public partial class FormAuthorization : Form
    {
        static string filePathListUsers = @"Data\accounts.json";
        List<User> users = new List<User>();

        string filePathListProducts = @"Data\products.json";
        List<Product> products = new List<Product>();

        string filePathListPromocodes = @"Data\promocodes.json";
        List<Promocode> promocodes = new List<Promocode>();

        public FormAuthorization()
        {
            InitializeComponent();
            cmbBoxSelectionAuthorization.SelectedIndex = 0;

            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\1.jpg");

            this.AcceptButton = btnEnterAccount;

            string jsonUsers = File.ReadAllText(filePathListUsers);
            users = JsonSerializer.Deserialize<List<User>>(jsonUsers);

            string jsonProducts = File.ReadAllText(filePathListProducts);
            products = JsonSerializer.Deserialize<List<Product>>(jsonProducts);

            string jsonPromocodes = File.ReadAllText(filePathListPromocodes);
            promocodes = JsonSerializer.Deserialize<List<Promocode>>(jsonPromocodes);
        }

        private void auth(string userName, bool isAdmin)
        {
            Form myForm = isAdmin ? new FormMainAdmin(userName, users, filePathListUsers, products, filePathListProducts, promocodes, filePathListPromocodes)
                : new FormMainUser(userName, products, filePathListProducts, promocodes, filePathListPromocodes);

            myForm.Show();
            this.Hide();
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
                AddingUser addNewUser = new AddingUser(newUser, ref users, filePathListUsers);
            }
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}
    