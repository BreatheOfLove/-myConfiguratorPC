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

namespace WinFormsApp9
{
    public partial class FormAddPromocode : Form
    {
        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        public FormAddPromocode(List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;
        }

        private void btnAddNewPromocode_Click(object sender, EventArgs e)
        {
            if(txtBoxPromocode.Text != string.Empty)
            {
                if (cmbBoxDiscoutAmount.SelectedIndex != -1)
                {
                    string promo = txtBoxPromocode.Text;
                    int discount = int.Parse(cmbBoxDiscoutAmount.SelectedItem.ToString());

                    Promocode promocode = new Promocode(promo, discount);
                    _promocodes.Add(promocode);
                    string json = JsonSerializer.Serialize(_promocodes, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
                    File.WriteAllText(_filePathListPromocodes, json);

                    MessageBox.Show("Промокод добавлен");
                }
                else 
                {
                    MessageBox.Show("Вы не выбрали размер скидки");
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели промокод");
            }
        }
    }
}
