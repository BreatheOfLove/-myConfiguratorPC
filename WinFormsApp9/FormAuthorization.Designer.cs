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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            btnEnterAccount = new Button();
            txtBoxInputPassword = new TextBox();
            txtBoxInputLogin = new TextBox();
            cmbBoxSelectionAuthorization = new ComboBox();
            imageList1 = new ImageList(components);
            pictureBoxBackground = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            SuspendLayout();
            // 
            // btnEnterAccount
            // 
            btnEnterAccount.Location = new Point(371, 230);
            btnEnterAccount.Name = "btnEnterAccount";
            btnEnterAccount.Size = new Size(121, 23);
            btnEnterAccount.TabIndex = 8;
            btnEnterAccount.Text = "Подтвердить";
            btnEnterAccount.UseVisualStyleBackColor = true;
            btnEnterAccount.Click += btnEnterAccount_Click;
            // 
            // txtBoxInputPassword
            // 
            txtBoxInputPassword.Location = new Point(371, 201);
            txtBoxInputPassword.Name = "txtBoxInputPassword";
            txtBoxInputPassword.PlaceholderText = "Пароль";
            txtBoxInputPassword.Size = new Size(121, 23);
            txtBoxInputPassword.TabIndex = 7;
            // 
            // txtBoxInputLogin
            // 
            txtBoxInputLogin.BackColor = SystemColors.Window;
            txtBoxInputLogin.ForeColor = SystemColors.WindowText;
            txtBoxInputLogin.Location = new Point(371, 172);
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
            cmbBoxSelectionAuthorization.Location = new Point(371, 143);
            cmbBoxSelectionAuthorization.Name = "cmbBoxSelectionAuthorization";
            cmbBoxSelectionAuthorization.Size = new Size(121, 23);
            cmbBoxSelectionAuthorization.TabIndex = 11;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(915, 539);
            pictureBoxBackground.TabIndex = 12;
            pictureBoxBackground.TabStop = false;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 539);
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
            Load += FormAuthorization_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnterAccount;
        private TextBox txtBoxInputPassword;
        private TextBox txtBoxInputLogin;
        private ComboBox cmbBoxSelectionAuthorization;
        private ImageList imageList1;
        private PictureBox pictureBoxBackground;
    }
}