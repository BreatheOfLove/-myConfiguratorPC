﻿namespace WinFormsApp9
{
    partial class FormAddingUserInAdminPanelcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxInputLogin = new TextBox();
            txtBoxInputPassword = new TextBox();
            cmbBoxIsAdmin = new ComboBox();
            btnAddingUser = new Button();
            comboBoxCity = new ComboBox();
            SuspendLayout();
            // 
            // txtBoxInputLogin
            // 
            txtBoxInputLogin.Location = new Point(287, 123);
            txtBoxInputLogin.Name = "txtBoxInputLogin";
            txtBoxInputLogin.PlaceholderText = "Логин";
            txtBoxInputLogin.Size = new Size(159, 23);
            txtBoxInputLogin.TabIndex = 0;
            // 
            // txtBoxInputPassword
            // 
            txtBoxInputPassword.Location = new Point(287, 152);
            txtBoxInputPassword.Name = "txtBoxInputPassword";
            txtBoxInputPassword.PlaceholderText = "Пароль";
            txtBoxInputPassword.Size = new Size(159, 23);
            txtBoxInputPassword.TabIndex = 1;
            // 
            // cmbBoxIsAdmin
            // 
            cmbBoxIsAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxIsAdmin.FormattingEnabled = true;
            cmbBoxIsAdmin.Items.AddRange(new object[] { "Администратор", "Пользователь" });
            cmbBoxIsAdmin.Location = new Point(287, 181);
            cmbBoxIsAdmin.Name = "cmbBoxIsAdmin";
            cmbBoxIsAdmin.Size = new Size(159, 23);
            cmbBoxIsAdmin.TabIndex = 2;
            // 
            // btnAddingUser
            // 
            btnAddingUser.Location = new Point(287, 239);
            btnAddingUser.Name = "btnAddingUser";
            btnAddingUser.Size = new Size(159, 23);
            btnAddingUser.TabIndex = 3;
            btnAddingUser.Text = "Создать";
            btnAddingUser.UseVisualStyleBackColor = true;
            btnAddingUser.Click += btnAddingUser_Click;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Москва", "Санкт-Петербург", "Екатеринбург", "Новосибирск", "Красноярск", "Сочи", "Краснодар", "Симферополь" });
            comboBoxCity.Location = new Point(287, 210);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(159, 23);
            comboBoxCity.TabIndex = 14;
            comboBoxCity.Tag = "";
            // 
            // FormAddingUserInAdminPanelcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCity);
            Controls.Add(btnAddingUser);
            Controls.Add(cmbBoxIsAdmin);
            Controls.Add(txtBoxInputPassword);
            Controls.Add(txtBoxInputLogin);
            Name = "FormAddingUserInAdminPanelcs";
            Text = "Панель добавления пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInputLogin;
        private TextBox txtBoxInputPassword;
        private ComboBox cmbBoxIsAdmin;
        private Button btnAddingUser;
        private ComboBox comboBoxCity;
    }
}