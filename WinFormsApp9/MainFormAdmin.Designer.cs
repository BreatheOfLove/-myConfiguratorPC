namespace WinFormsApp9
{
    partial class MainFormAdmin
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
            lblHelloText = new Label();
            lblLoginUser = new Label();
            btnAddNewUser = new Button();
            SuspendLayout();
            // 
            // lblHelloText
            // 
            lblHelloText.AutoSize = true;
            lblHelloText.Location = new Point(614, 9);
            lblHelloText.Name = "lblHelloText";
            lblHelloText.Size = new Size(115, 15);
            lblHelloText.TabIndex = 13;
            lblHelloText.Text = "Добро пожаловать,";
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Location = new Point(726, 9);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(12, 15);
            lblLoginUser.TabIndex = 12;
            lblLoginUser.Text = "*";
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(43, 34);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(108, 23);
            btnAddNewUser.TabIndex = 14;
            btnAddNewUser.Text = "Создать аккаунт";
            btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // MainFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNewUser);
            Controls.Add(lblHelloText);
            Controls.Add(lblLoginUser);
            Name = "MainFormAdmin";
            Text = "Панель администратора";
            Load += MainFormAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloText;
        private Label lblLoginUser;
        private Button btnAddNewUser;
    }
}