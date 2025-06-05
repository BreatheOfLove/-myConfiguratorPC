using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp9
{
    public partial class FormAddAccessories : Form
    {
        List<Product> _products = new List<Product>();
        string _filePathListProd = "";

        public FormAddAccessories(List<Product> products, string filePathListProd)
        {
            InitializeComponent();

            _products = products;
            _filePathListProd = filePathListProd;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            int parsedValue;
            bool isChoice = int.TryParse(txtBoxProdPrice.Text, out parsedValue) ? true : false;
            if (cmbBoxTypeProd.SelectedIndex > -1 && txtBoxProdName.Text != string.Empty && txtBoxProdPrice.Text != string.Empty && isChoice)
            {
                string type = cmbBoxTypeProd.SelectedItem.ToString();
                string name = txtBoxProdName.Text;
                string description = txtBoxProdDescription.Text;

                int price = int.Parse(txtBoxProdPrice.Text);

                Product product = new Product(type, name, description, price);
                _products.Add(product);
                string json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping});
                File.WriteAllText(_filePathListProd, json);

                MessageBox.Show("Компонент добавлен");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
