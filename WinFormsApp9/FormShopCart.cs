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
        List<Product> _shopCartProducts;
        int _sumProd = 0;
        public FormShopCart(List<Product> shopCartProducts, int sumProd)
        {
            InitializeComponent();
            _shopCartProducts = shopCartProducts;
            _sumProd = sumProd;

            updateSumProducts(sumProd);

            foreach (var product in _shopCartProducts)
            {
                listBoxShopCart.Items.Add($"Тип: {product.Type}, название: {product.Name}, описание: {product.Description}, цена: {product.Price}");
            }
        }

        private void updateSumProducts(int sumProd)
        {
            lblSumProducts.Text = sumProd.ToString();
        }

        private void btnPayProduct_Click(object sender, EventArgs e)
        {
            if (listBoxShopCart.SelectedIndex >= 0)
            {
                FormPayProducts formPayProducts = new FormPayProducts();
                formPayProducts.ShowDialog();

                if(formPayProducts.getIsPay())
                {
                    int deleteSelectedIndex = listBoxShopCart.SelectedIndex;
                    int deletePrice = _shopCartProducts[listBoxShopCart.SelectedIndex].Price;

                    _shopCartProducts.RemoveAt(deleteSelectedIndex);
                    listBoxShopCart.Items.RemoveAt(deleteSelectedIndex);
                    _sumProd -= deletePrice;
                    updateSumProducts(_sumProd);

                    if(listBoxShopCart.Items.Count == 0)
                    {
                        MessageBox.Show("Будем ждать вас ещё");
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран товар");
            }
        }

        private void btnPayAllProducts_Click(object sender, EventArgs e)
        {
            if(_sumProd > 0)
            {
                FormPayProducts formPayProducts = new FormPayProducts();
                formPayProducts.ShowDialog();

                if (formPayProducts.getIsPay())
                {
                    _shopCartProducts.Clear();
                    _sumProd = 0;
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Ваша корзина пуста (((((");
            }
        }
    }
}
