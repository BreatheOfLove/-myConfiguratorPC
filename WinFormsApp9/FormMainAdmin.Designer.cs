namespace WinFormsApp9
{
    partial class FormMainAdmin
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
            btnAddAccessories = new Button();
            pictureBoxBackground = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
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
            btnAddNewUser.Location = new Point(277, 112);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(173, 23);
            btnAddNewUser.TabIndex = 14;
            btnAddNewUser.Text = "Добавить пользователя";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // btnAddAccessories
            // 
            btnAddAccessories.Location = new Point(277, 141);
            btnAddAccessories.Name = "btnAddAccessories";
            btnAddAccessories.Size = new Size(173, 23);
            btnAddAccessories.TabIndex = 15;
            btnAddAccessories.Text = "Добавить комплектующие";
            btnAddAccessories.UseVisualStyleBackColor = true;
            btnAddAccessories.Click += btnAddAccessories_Click;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(799, 451);
            pictureBoxBackground.TabIndex = 16;
            pictureBoxBackground.TabStop = false;
            pictureBoxBackground.Click += pictureBoxBackground_Click;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddAccessories);
            Controls.Add(btnAddNewUser);
            Controls.Add(lblHelloText);
            Controls.Add(lblLoginUser);
            Controls.Add(pictureBoxBackground);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMainAdmin";
            Text = "Панель администратора";
            Load += FormMainAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloText;
        private Label lblLoginUser;
        private Button btnAddNewUser;
        private Button btnAddAccessories;
        private PictureBox pictureBoxBackground;
    }
}