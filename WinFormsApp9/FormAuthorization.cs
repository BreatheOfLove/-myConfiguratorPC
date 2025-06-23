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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinFormsApp9
{
    public partial class FormAuthorization : Form
    {
        string filePathListUsers = @"Data\accounts.json";
        List<User> users = new List<User>();

        string filePathListProducts = @"Data\accessories.json";
        List<Accessories> accessories = new List<Accessories>();

        string filePathListPromocodes = @"Data\promocodes.json";
        List<Promocode> promocodes = new List<Promocode>();

        public FormAuthorization()
        {
            InitializeComponent();
            cmbBoxSelectionAuthorization.SelectedIndex = 0;
            txtBoxInputPassword.PasswordChar = '*';
            pictureBoxBackground.Image = System.Drawing.Image.FromFile(@"Data\1.jpg");

            this.AcceptButton = btnEnterAccount;

            string jsonUsers = File.ReadAllText(filePathListUsers);
            users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(jsonUsers);

            string jsonAccessories = File.ReadAllText(filePathListProducts);
            accessories = System.Text.Json.JsonSerializer.Deserialize<List<Accessories>>(jsonAccessories);

            string jsonPromocodes = File.ReadAllText(filePathListPromocodes);
            promocodes = System.Text.Json.JsonSerializer.Deserialize<List<Promocode>>(jsonPromocodes);
        }

        static private async Task<string> findWeather(string City)
        {   
            string apiKey = "3430279d3200423597f12155251606";

            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={City}";

            using HttpClient client = new HttpClient();
            string data = await client.GetStringAsync(url);

            var jobject = JObject.Parse(data);
            double temp = (double)jobject["current"]["temp_c"];

            return temp.ToString();
        }

        private async Task auth(User user)
        {
            try
            {
                string weather = await findWeather(user.City);

                this.Hide();
                Form myForm = user.IsAdmin ? new FormMainAdmin(user, weather, users, filePathListUsers, accessories, filePathListProducts, promocodes, filePathListPromocodes)
                    : new FormMainUser(user, users, filePathListUsers, weather, accessories, filePathListProducts, promocodes, filePathListPromocodes);
                myForm.FormClosed += (s, e) => Environment.Exit(0);
                myForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnterAccount_Click(object sender, EventArgs e)
        {
            string usernameInput = txtBoxInputLogin.Text;
            string passwordInput = txtBoxInputPassword.Text;

            if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Вход")
            {
                User authorizedUser = authInAccount.isAuthInAccount(usernameInput, passwordInput, ref users);

                if (authorizedUser != null)
                {
                    auth(authorizedUser);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Регистрация")
            {
                if (usernameInput != string.Empty && passwordInput != string.Empty && comboBoxCity.SelectedItem != null)
                {
                    string cityInput = comboBoxCity.SelectedItem.ToString();
                    List<Accessories> purchaseHistory = new List<Accessories>();
                    User newUser = new User(usernameInput, hashPass.GetHashSHA256(passwordInput), cityInput, false, purchaseHistory);
                    AddingUser.addNewUser(newUser, ref users, filePathListUsers);
                }
                else
                {
                    MessageBox.Show("Вы заполнили не все поля");
                }
            }
        }

        private void cmbBoxSelectionAuthorization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSelectionAuthorization.SelectedItem == "Вход") { comboBoxCity.Visible = false; }
            else if (cmbBoxSelectionAuthorization.SelectedItem == "Регистрация") { comboBoxCity.Visible = true; }
        }
    }
}
    