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

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";
        public FormShopCart(List<Product> shopCartProducts, int sumProd, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();

            _shopCartProducts = shopCartProducts;
            _sumProd = sumProd;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;

            updateSumProducts(sumProd);

            foreach (var product in _shopCartProducts)
            {
                listBoxShopCart.Items.Add($"Тип: {product.Type}, название: {product.Name}, описание: {product.Description}, цена: {product.Price}");
            }
        }

        private void updateSumProducts(int sumProd)
        {
            double doubleSumProd = Convert.ToDouble(sumProd);
            lblSumProducts.Text = doubleSumProd.ToString();
        }

        private void btnPayProduct_Click(object sender, EventArgs e)
        {
            if (listBoxShopCart.SelectedIndex >= 0)
            {
                FormPayProducts formPayProducts = new FormPayProducts();
                formPayProducts.ShowDialog();

                if (formPayProducts.getIsPay())
                {
                    int deleteSelectedIndex = listBoxShopCart.SelectedIndex;
                    int deletePrice = _shopCartProducts[listBoxShopCart.SelectedIndex].Price;

                    _shopCartProducts.RemoveAt(deleteSelectedIndex);
                    listBoxShopCart.Items.RemoveAt(deleteSelectedIndex);
                    _sumProd -= deletePrice;
                    updateSumProducts(_sumProd);

                    if (listBoxShopCart.Items.Count == 0)
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
            if (_sumProd > 0)
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

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (listBoxShopCart.SelectedIndex >= 0)
            {
                int deleteSelectedIndex = listBoxShopCart.SelectedIndex;
                int deletePrice = _shopCartProducts[listBoxShopCart.SelectedIndex].Price;

                _sumProd -= deletePrice;
                _shopCartProducts.RemoveAt(deleteSelectedIndex);zAZ
                listBoxShopCart.Items.RemoveAt(deleteSelectedIndex);
                updateSumProducts(_sumProd);
                MessageBox.Show("Товар удалён из корзины");
            }
            else
            {
                MessageBox.Show("Не выбран товар");
            }
        }

        private void btnInputPromocode_Click(object sender, EventArgs e)
        {
            foreach(var promocode in _promocodes)
            {
                if(promocode.Promo == txtBoxPromocode.Text)
                {
                    _sumProd = (int)(_sumProd * (1 - (double)promocode.Discount / 100));

                    updateSumProducts(_sumProd);
                    lblDiscountAmonut.Text = promocode.Discount.ToString();
                    MessageBox.Show("Промокод применён");

                    return;
                }
            }
            MessageBox.Show("Такого промокода нет");
        }
    }
}
