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
            btnInputShopCart = new Button();
            pictureBoxBackground = new PictureBox();
            lblTextWeaher = new Label();
            btnOpenListPurchaseHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            SuspendLayout();
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.BackColor = Color.FromArgb(192, 192, 255);
            lblLoginUser.Location = new Point(719, 9);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(13, 15);
            lblLoginUser.TabIndex = 10;
            lblLoginUser.Text = "1";
            // 
            // lblHelloText
            // 
            lblHelloText.AutoSize = true;
            lblHelloText.BackColor = Color.FromArgb(255, 192, 192);
            lblHelloText.Location = new Point(598, 9);
            lblHelloText.Name = "lblHelloText";
            lblHelloText.Size = new Size(115, 15);
            lblHelloText.TabIndex = 11;
            lblHelloText.Text = "Добро пожаловать,";
            // 
            // btnOpenListProducts
            // 
            btnOpenListProducts.Location = new Point(38, 123);
            btnOpenListProducts.Name = "btnOpenListProducts";
            btnOpenListProducts.Size = new Size(156, 23);
            btnOpenListProducts.TabIndex = 12;
            btnOpenListProducts.Text = "Открыть список товаров";
            btnOpenListProducts.UseVisualStyleBackColor = true;
            btnOpenListProducts.Click += btnOpenListProducts_Click;
            // 
            // btnInputShopCart
            // 
            btnInputShopCart.Location = new Point(38, 152);
            btnInputShopCart.Name = "btnInputShopCart";
            btnInputShopCart.Size = new Size(156, 23);
            btnInputShopCart.TabIndex = 14;
            btnInputShopCart.Text = "Корзина";
            btnInputShopCart.UseVisualStyleBackColor = true;
            btnInputShopCart.Click += btnInputShopCart_Click;
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Location = new Point(0, -3);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(799, 452);
            pictureBoxBackground.TabIndex = 15;
            pictureBoxBackground.TabStop = false;
            // 
            // lblTextWeaher
            // 
            lblTextWeaher.AutoSize = true;
            lblTextWeaher.BackColor = Color.FromArgb(255, 192, 192);
            lblTextWeaher.Location = new Point(598, 36);
            lblTextWeaher.Name = "lblTextWeaher";
            lblTextWeaher.Size = new Size(86, 15);
            lblTextWeaher.TabIndex = 16;
            lblTextWeaher.Text = "В * сейчас 0.0°";
            // 
            // btnOpenListPurchaseHistory
            // 
            btnOpenListPurchaseHistory.Location = new Point(589, 69);
            btnOpenListPurchaseHistory.Name = "btnOpenListPurchaseHistory";
            btnOpenListPurchaseHistory.Size = new Size(173, 23);
            btnOpenListPurchaseHistory.TabIndex = 17;
            btnOpenListPurchaseHistory.Text = "Открыть историю покупок";
            btnOpenListPurchaseHistory.UseVisualStyleBackColor = true;
            btnOpenListPurchaseHistory.Click += btnOpenListPurchaseHistory_Click;
            // 
            // FormMainUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenListPurchaseHistory);
            Controls.Add(lblTextWeaher);
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
        private Button btnInputShopCart;
        private PictureBox pictureBoxBackground;
        private Label lblTextWeaher;
        private Button btnOpenListPurchaseHistory;
    }
}
