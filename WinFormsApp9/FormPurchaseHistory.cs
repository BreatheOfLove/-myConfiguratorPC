﻿using System;
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
    public partial class FormPurchaseHistory : Form
    {
        public FormPurchaseHistory(List<Accessories> listPurchaseHistory)
        {
            InitializeComponent();

            foreach (Accessories accessories in listPurchaseHistory)
            {
                listBoxPurchaseHistory.Items.Add($"Тип: {accessories.Type}, название: {accessories.Name}, описание: {accessories.Description}, цена: {accessories.Price}");
            }
        }

        private void FormPurchaseHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
