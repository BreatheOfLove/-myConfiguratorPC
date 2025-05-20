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

namespace WinFormsApp9
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            cmbBoxSelectionAuthorization.SelectedIndex = 0;
        }

        private void btnEnterAccount_Click(object sender, EventArgs e)
        {
            if (cmbBoxSelectionAuthorization.SelectedItem != null)
            {
                if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Вход")
                {
                    
                }   
                else if (cmbBoxSelectionAuthorization.SelectedItem.ToString() == "Регистрация")
                {
                    if (checkLogin.loginIsHave(txtBoxInputLogin.ToString()) && checkPassword.passwordIsLength(txtBoxInputPassword.ToString()))
                    {
                        string jsonUser = JsonSerializer.Serialize(person);
                    }
                }
            }
        }

    }
}
