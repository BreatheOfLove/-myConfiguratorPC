using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormShopCart : Form
    {
        public FormShopCart(User user, List<User> users, string filePathListUsers ,List<Accessories> shopCartAccessories, int sumProd, List<Promocode> promocodes, string filePathListPromocodes)
        {
            InitializeComponent();

            _user = user;

            _users = users;
            _filePathListUsers = filePathListUsers;

            _shopCartAccessories = shopCartAccessories;
            _sumAccessories = sumProd;

            _promocodes = promocodes;
            _filePathListPromocodes = filePathListPromocodes;


            updateSumAccessories(sumProd);

            foreach (var accessories in _shopCartAccessories)
            {
                listBoxShopCart.Items.Add($"Тип: {accessories.Type}, название: {accessories.Name}, описание: {accessories.Description}, цена: {accessories.Price}");
            }
        }

        string _filePathListUsers = "";
        List<User> _users = new List<User>();

        List<Accessories> _shopCartAccessories;
        int _sumAccessories = 0;

        List<Promocode> _promocodes = new List<Promocode>();
        string _filePathListPromocodes = "";

        int _sumAccessoriesWithDiscount = 0;

        User _user;

        public void SaveUsersToFile()
        {
            var json = JsonSerializer.Serialize(_users, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(_filePathListUsers, json);
        }

        private void updateSumAccessories(int sumProd)
        {
            lblSumProducts.Text = sumProd.ToString();
        }

        private void updateSumWithAccessories(int sumWithDiscountProd)
        {
            if(sumWithDiscountProd > 0)
            {
                double doubleSumProdWithDiscount = Convert.ToDouble(sumWithDiscountProd);
                lblSumProductsWithDiscount.Text = doubleSumProdWithDiscount.ToString();
            }
            else
            {
                lblSumProducts.Font = new Font(lblSumProducts.Font, FontStyle.Regular);
                lblSumProductsWithDiscount.Text = string.Empty;
            }
        }

        private void sumAccessoriesIsNull()
        {
            if (_sumAccessories <= 0)
            {
                _sumAccessoriesWithDiscount = 0;
                updateSumWithAccessories(_sumAccessoriesWithDiscount);
            }
        }

        public int getSumShopCarts()
        {
            return _sumAccessories;
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
                    int deletePrice = _shopCartAccessories[listBoxShopCart.SelectedIndex].Price;

                    _user.Purchases.Add(_shopCartAccessories[deleteSelectedIndex]);
                    SaveUsersToFile();

                    _shopCartAccessories.RemoveAt(deleteSelectedIndex);
                    listBoxShopCart.Items.RemoveAt(deleteSelectedIndex);
                    _sumAccessories -= deletePrice;
                    updateSumAccessories(_sumAccessories);

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
            if (_sumAccessories > 0)
            {
                FormPayProducts formPayProducts = new FormPayProducts();
                formPayProducts.ShowDialog();

                if (formPayProducts.getIsPay())
                {
                    _shopCartAccessories.Clear();
                    _sumAccessories = 0;
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
                int deletePrice = _shopCartAccessories[listBoxShopCart.SelectedIndex].Price;

                _sumAccessories -= deletePrice;
                _shopCartAccessories.RemoveAt(deleteSelectedIndex);
                listBoxShopCart.Items.RemoveAt(deleteSelectedIndex);
                updateSumAccessories(_sumAccessories);
                MessageBox.Show("Товар удалён из корзины");

                sumAccessoriesIsNull();
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
                    _sumAccessoriesWithDiscount= (int)(_sumAccessories * (1 - (double)promocode.Discount / 100));
                    updateSumWithAccessories(_sumAccessoriesWithDiscount);

                    lblSumProducts.Font = new Font(lblSumProducts.Font, FontStyle.Strikeout);
                    lblDiscountAmonut.Text = promocode.Discount.ToString();

                    MessageBox.Show("Промокод применён");

                    return;
                }
            }
            MessageBox.Show("Такого промокода нет");
        }
    }
}
