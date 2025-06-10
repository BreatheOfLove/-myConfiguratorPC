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
    public partial class FormPayProducts : Form
    {
        bool isPay = false;
        public FormPayProducts()
        {
            InitializeComponent();

            pictureBoxQRCodePay.Image = System.Drawing.Image.FromFile(@"Data\qr_oplata.jpg");
            pictureBoxQRCodePay.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public bool getIsPay()
        {
            return isPay;
        }

        private void btnCheckPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата прошла успешно. Спасибо за покупку");
            this.Close();
            isPay = true;
        }

        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
