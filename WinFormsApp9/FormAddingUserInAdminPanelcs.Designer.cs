namespace WinFormsApp9
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
            SuspendLayout();
            // 
            // txtBoxInputLogin
            // 
            txtBoxInputLogin.Location = new Point(282, 34);
            txtBoxInputLogin.Name = "txtBoxInputLogin";
            txtBoxInputLogin.PlaceholderText = "Логин";
            txtBoxInputLogin.Size = new Size(159, 23);
            txtBoxInputLogin.TabIndex = 0;
            // 
            // txtBoxInputPassword
            // 
            txtBoxInputPassword.Location = new Point(282, 63);
            txtBoxInputPassword.Name = "txtBoxInputPassword";
            txtBoxInputPassword.PlaceholderText = "Пароль";
            txtBoxInputPassword.Size = new Size(159, 23);
            txtBoxInputPassword.TabIndex = 1;
            // 
            // cmbBoxIsAdmin
            // 
            cmbBoxIsAdmin.FormattingEnabled = true;
            cmbBoxIsAdmin.Items.AddRange(new object[] { "Администратор", "Пользователь" });
            cmbBoxIsAdmin.Location = new Point(282, 92);
            cmbBoxIsAdmin.Name = "cmbBoxIsAdmin";
            cmbBoxIsAdmin.Size = new Size(159, 23);
            cmbBoxIsAdmin.TabIndex = 2;
            // 
            // btnAddingUser
            // 
            btnAddingUser.Location = new Point(282, 121);
            btnAddingUser.Name = "btnAddingUser";
            btnAddingUser.Size = new Size(159, 23);
            btnAddingUser.TabIndex = 3;
            btnAddingUser.Text = "Создать";
            btnAddingUser.UseVisualStyleBackColor = true;
            btnAddingUser.Click += btnAddingUser_Click;
            // 
            // FormAddingUserInAdminPanelcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}