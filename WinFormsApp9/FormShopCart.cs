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
    public partial class FormShopCart : Form
    {
        public FormShopCart(List<Product> shopCartProducts)
        {
            InitializeComponent();
            
        }

        private void FormShopCart_Load(object sender, EventArgs e)
        {

        }

        private void btnPayProduct_Click(object sender, EventArgs e)
        {
            if(listBoxShopCart.SelectedIndex > 0)
            {

            }
            else
            {
                MessageBox.Show("Не выбран товар");
            }
        }
    }
}
