namespace WinFormsApp9
{
    partial class MainFormUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoginUser = new Label();
            lblHelloText = new Label();
            SuspendLayout();
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Location = new Point(710, 9);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(12, 15);
            lblLoginUser.TabIndex = 10;
            lblLoginUser.Text = "*";
            // 
            // lblHelloText
            // 
            lblHelloText.AutoSize = true;
            lblHelloText.Location = new Point(598, 9);
            lblHelloText.Name = "lblHelloText";
            lblHelloText.Size = new Size(115, 15);
            lblHelloText.TabIndex = 11;
            lblHelloText.Text = "Добро пожаловать,";
            // 
            // MainFormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloText);
            Controls.Add(lblLoginUser);
            Name = "MainFormUser";
            Text = "Панель пользователя";
            Load += MainFormUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLoginUser;
        private Label lblHelloText;
    }
}
