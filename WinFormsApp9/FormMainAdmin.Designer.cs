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
            btnAddNewAccessories = new Button();
            pictureBoxBackground = new PictureBox();
            btnAddNewPromocode = new Button();
            lblTextWeaher = new Label();
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
            // btnAddNewAccessories
            // 
            btnAddNewAccessories.Location = new Point(277, 141);
            btnAddNewAccessories.Name = "btnAddNewAccessories";
            btnAddNewAccessories.Size = new Size(173, 23);
            btnAddNewAccessories.TabIndex = 15;
            btnAddNewAccessories.Text = "Добавить комплектующие";
            btnAddNewAccessories.UseVisualStyleBackColor = true;
            btnAddNewAccessories.Click += btnAddAccessories_Click;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(0, -1);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(799, 451);
            pictureBoxBackground.TabIndex = 16;
            pictureBoxBackground.TabStop = false;
            // 
            // btnAddNewPromocode
            // 
            btnAddNewPromocode.Location = new Point(277, 170);
            btnAddNewPromocode.Name = "btnAddNewPromocode";
            btnAddNewPromocode.Size = new Size(173, 23);
            btnAddNewPromocode.TabIndex = 17;
            btnAddNewPromocode.Text = "Создать промокод";
            btnAddNewPromocode.UseVisualStyleBackColor = true;
            btnAddNewPromocode.Click += btnAddNewPromocode_Click;
            // 
            // lblTextWeaher
            // 
            lblTextWeaher.AutoSize = true;
            lblTextWeaher.Location = new Point(614, 36);
            lblTextWeaher.Name = "lblTextWeaher";
            lblTextWeaher.Size = new Size(86, 15);
            lblTextWeaher.TabIndex = 18;
            lblTextWeaher.Text = "В * сейчас 0.0°";
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTextWeaher);
            Controls.Add(btnAddNewPromocode);
            Controls.Add(btnAddNewAccessories);
            Controls.Add(btnAddNewUser);
            Controls.Add(lblHelloText);
            Controls.Add(lblLoginUser);
            Controls.Add(pictureBoxBackground);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMainAdmin";
            Text = "Панель администратора";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloText;
        private Label lblLoginUser;
        private Button btnAddNewUser;
        private Button btnAddNewAccessories;
        private PictureBox pictureBoxBackground;
        private Button btnAddNewPromocode;
        private Label lblTextWeaher;
    }
}