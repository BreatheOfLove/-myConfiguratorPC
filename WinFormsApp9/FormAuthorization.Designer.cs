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
            btnEnterAccount = new Button();
            txtBoxInputPassword = new TextBox();
            txtBoxInputLogin = new TextBox();
            cmbBoxSelectionAuthorization = new ComboBox();
            SuspendLayout();
            // 
            // btnEnterAccount
            // 
            btnEnterAccount.Location = new Point(310, 167);
            btnEnterAccount.Name = "btnEnterAccount";
            btnEnterAccount.Size = new Size(121, 23);
            btnEnterAccount.TabIndex = 8;
            btnEnterAccount.Text = "Подтвердить";
            btnEnterAccount.UseVisualStyleBackColor = true;
            btnEnterAccount.Click += btnEnterAccount_Click;
            // 
            // txtBoxInputPassword
            // 
            txtBoxInputPassword.Location = new Point(310, 138);
            txtBoxInputPassword.Name = "txtBoxInputPassword";
            txtBoxInputPassword.PlaceholderText = "Пароль";
            txtBoxInputPassword.Size = new Size(121, 23);
            txtBoxInputPassword.TabIndex = 7;
            // 
            // txtBoxInputLogin
            // 
            txtBoxInputLogin.Location = new Point(310, 109);
            txtBoxInputLogin.Name = "txtBoxInputLogin";
            txtBoxInputLogin.PlaceholderText = "Логин";
            txtBoxInputLogin.Size = new Size(121, 23);
            txtBoxInputLogin.TabIndex = 6;
            // 
            // cmbBoxSelectionAuthorization
            // 
            cmbBoxSelectionAuthorization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSelectionAuthorization.FormattingEnabled = true;
            cmbBoxSelectionAuthorization.Items.AddRange(new object[] { "Вход", "Регистрация" });
            cmbBoxSelectionAuthorization.Location = new Point(310, 80);
            cmbBoxSelectionAuthorization.Name = "cmbBoxSelectionAuthorization";
            cmbBoxSelectionAuthorization.Size = new Size(121, 23);
            cmbBoxSelectionAuthorization.TabIndex = 11;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBoxSelectionAuthorization);
            Controls.Add(btnEnterAccount);
            Controls.Add(txtBoxInputPassword);
            Controls.Add(txtBoxInputLogin);
            Name = "FormAuthorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnterAccount;
        private TextBox txtBoxInputPassword;
        private TextBox txtBoxInputLogin;
        private ComboBox cmbBoxSelectionAuthorization;
    }
}