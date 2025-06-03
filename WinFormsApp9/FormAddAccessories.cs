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
    public partial class FormAddAccessories : Form
    {
        string _filePathListProd = "";

        public FormAddAccessories(string filePathListProd)
        {
            InitializeComponent();
            _filePathListProd = filePathListProd;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {

        }
    }
}
