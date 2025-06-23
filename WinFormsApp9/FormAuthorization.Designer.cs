namespace WinFormsApp9
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            btnEnterAccount = new Button();
            txtBoxInputPassword = new TextBox();
            txtBoxInputLogin = new TextBox();
            cmbBoxSelectionAuthorization = new ComboBox();
            pictureBoxBackground = new PictureBox();
            comboBoxCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            SuspendLayout();
            // 
            // btnEnterAccount
            // 
            btnEnterAccount.Location = new Point(296, 246);
            btnEnterAccount.Name = "btnEnterAccount";
            btnEnterAccount.Size = new Size(154, 23);
            btnEnterAccount.TabIndex = 8;
            btnEnterAccount.Text = "Подтвердить";
            btnEnterAccount.UseVisualStyleBackColor = true;
            btnEnterAccount.Click += btnEnterAccount_Click;
            // 
            // txtBoxInputPassword
            // 
            txtBoxInputPassword.Location = new Point(296, 188);
            txtBoxInputPassword.Name = "txtBoxInputPassword";
            txtBoxInputPassword.PlaceholderText = "Пароль";
            txtBoxInputPassword.Size = new Size(154, 23);
            txtBoxInputPassword.TabIndex = 7;
            // 
            // txtBoxInputLogin
            // 
            txtBoxInputLogin.BackColor = SystemColors.Window;
            txtBoxInputLogin.ForeColor = SystemColors.WindowText;
            txtBoxInputLogin.Location = new Point(296, 159);
            txtBoxInputLogin.Name = "txtBoxInputLogin";
            txtBoxInputLogin.PlaceholderText = "Логин";
            txtBoxInputLogin.Size = new Size(154, 23);
            txtBoxInputLogin.TabIndex = 6;
            // 
            // cmbBoxSelectionAuthorization
            // 
            cmbBoxSelectionAuthorization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSelectionAuthorization.FormattingEnabled = true;
            cmbBoxSelectionAuthorization.Items.AddRange(new object[] { "Вход", "Регистрация" });
            cmbBoxSelectionAuthorization.Location = new Point(296, 130);
            cmbBoxSelectionAuthorization.Name = "cmbBoxSelectionAuthorization";
            cmbBoxSelectionAuthorization.Size = new Size(154, 23);
            cmbBoxSelectionAuthorization.TabIndex = 11;
            cmbBoxSelectionAuthorization.SelectedIndexChanged += cmbBoxSelectionAuthorization_SelectedIndexChanged;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(-1, -6);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(798, 454);
            pictureBoxBackground.TabIndex = 12;
            pictureBoxBackground.TabStop = false;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Москва", "Санкт-Петербург", "Екатеринбург", "Новосибирск", "Красноярск", "Сочи", "Краснодар", "Симферополь" });
            comboBoxCity.Location = new Point(296, 217);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(154, 23);
            comboBoxCity.TabIndex = 13;
            comboBoxCity.Tag = "";
            comboBoxCity.Visible = false;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 446);
            Controls.Add(comboBoxCity);
            Controls.Add(cmbBoxSelectionAuthorization);
            Controls.Add(btnEnterAccount);
            Controls.Add(txtBoxInputPassword);
            Controls.Add(txtBoxInputLogin);
            Controls.Add(pictureBoxBackground);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAuthorization";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnterAccount;
        private TextBox txtBoxInputPassword;
        private TextBox txtBoxInputLogin;
        private ComboBox cmbBoxSelectionAuthorization;
        private PictureBox pictureBoxBackground;
        private ComboBox comboBoxCity;
    }
}