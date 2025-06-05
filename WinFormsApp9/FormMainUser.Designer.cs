namespace WinFormsApp9
{
    partial class FormMainUser
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
            btnOpenListProducts = new Button();
            pictureBoxBackground = new PictureBox();
            btnInputShopCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
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
            // btnOpenListProducts
            // 
            btnOpenListProducts.Location = new Point(243, 138);
            btnOpenListProducts.Name = "btnOpenListProducts";
            btnOpenListProducts.Size = new Size(156, 23);
            btnOpenListProducts.TabIndex = 12;
            btnOpenListProducts.Text = "Открыть список товаров";
            btnOpenListProducts.UseVisualStyleBackColor = true;
            btnOpenListProducts.Click += btnOpenListProducts_Click;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(-2, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(800, 450);
            pictureBoxBackground.TabIndex = 13;
            pictureBoxBackground.TabStop = false;
            // 
            // btnInputShopCart
            // 
            btnInputShopCart.Location = new Point(243, 178);
            btnInputShopCart.Name = "btnInputShopCart";
            btnInputShopCart.Size = new Size(156, 23);
            btnInputShopCart.TabIndex = 14;
            btnInputShopCart.Text = "Корзина";
            btnInputShopCart.UseVisualStyleBackColor = true;
            // 
            // FormMainUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInputShopCart);
            Controls.Add(btnOpenListProducts);
            Controls.Add(lblHelloText);
            Controls.Add(lblLoginUser);
            Controls.Add(pictureBoxBackground);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMainUser";
            Text = "Панель пользователя";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLoginUser;
        private Label lblHelloText;
        private Button btnOpenListProducts;
        private PictureBox pictureBoxBackground;
        private Button btnInputShopCart;
    }
}
