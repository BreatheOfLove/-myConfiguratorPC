namespace WinFormsApp9
{
    partial class FormShopCart
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
            listBoxShopCart = new ListBox();
            btnPayAllProducts = new Button();
            btnPayProduct = new Button();
            lblTextSumProd = new Label();
            lblSumProducts = new Label();
            btnDeleteProd = new Button();
            btnInputPromocode = new Button();
            txtBoxPromocode = new TextBox();
            lblTextDiscount = new Label();
            lblDiscountAmonut = new Label();
            lblTextProcent = new Label();
            SuspendLayout();
            // 
            // listBoxShopCart
            // 
            listBoxShopCart.FormattingEnabled = true;
            listBoxShopCart.ItemHeight = 15;
            listBoxShopCart.Location = new Point(12, 12);
            listBoxShopCart.Name = "listBoxShopCart";
            listBoxShopCart.Size = new Size(755, 319);
            listBoxShopCart.TabIndex = 0;
            // 
            // btnPayAllProducts
            // 
            btnPayAllProducts.Location = new Point(345, 406);
            btnPayAllProducts.Name = "btnPayAllProducts";
            btnPayAllProducts.Size = new Size(121, 23);
            btnPayAllProducts.TabIndex = 2;
            btnPayAllProducts.Text = "Оплатить корзину";
            btnPayAllProducts.UseVisualStyleBackColor = true;
            btnPayAllProducts.Click += btnPayAllProducts_Click;
            // 
            // btnPayProduct
            // 
            btnPayProduct.Location = new Point(345, 348);
            btnPayProduct.Name = "btnPayProduct";
            btnPayProduct.Size = new Size(121, 23);
            btnPayProduct.TabIndex = 1;
            btnPayProduct.Text = "Оплатить товар";
            btnPayProduct.UseVisualStyleBackColor = true;
            btnPayProduct.Click += btnPayProduct_Click;
            // 
            // lblTextSumProd
            // 
            lblTextSumProd.AutoSize = true;
            lblTextSumProd.Location = new Point(582, 357);
            lblTextSumProd.Name = "lblTextSumProd";
            lblTextSumProd.Size = new Size(99, 15);
            lblTextSumProd.TabIndex = 5;
            lblTextSumProd.Text = "Сумма корзины:";
            // 
            // lblSumProducts
            // 
            lblSumProducts.AutoSize = true;
            lblSumProducts.Location = new Point(687, 357);
            lblSumProducts.Name = "lblSumProducts";
            lblSumProducts.Size = new Size(13, 15);
            lblSumProducts.TabIndex = 4;
            lblSumProducts.Text = "0";
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.Location = new Point(345, 377);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(121, 23);
            btnDeleteProd.TabIndex = 6;
            btnDeleteProd.Text = "Удалить товар";
            btnDeleteProd.UseVisualStyleBackColor = true;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // btnInputPromocode
            // 
            btnInputPromocode.Location = new Point(68, 378);
            btnInputPromocode.Name = "btnInputPromocode";
            btnInputPromocode.Size = new Size(187, 23);
            btnInputPromocode.TabIndex = 7;
            btnInputPromocode.Text = "Применить";
            btnInputPromocode.UseVisualStyleBackColor = true;
            btnInputPromocode.Click += btnInputPromocode_Click;
            // 
            // txtBoxPromocode
            // 
            txtBoxPromocode.Location = new Point(68, 349);
            txtBoxPromocode.Name = "txtBoxPromocode";
            txtBoxPromocode.PlaceholderText = "Промокод";
            txtBoxPromocode.Size = new Size(187, 23);
            txtBoxPromocode.TabIndex = 8;
            // 
            // lblTextDiscount
            // 
            lblTextDiscount.AutoSize = true;
            lblTextDiscount.Location = new Point(582, 385);
            lblTextDiscount.Name = "lblTextDiscount";
            lblTextDiscount.Size = new Size(80, 15);
            lblTextDiscount.TabIndex = 10;
            lblTextDiscount.Text = "Ваша скидка:";
            // 
            // lblDiscountAmonut
            // 
            lblDiscountAmonut.AutoSize = true;
            lblDiscountAmonut.Location = new Point(668, 385);
            lblDiscountAmonut.Name = "lblDiscountAmonut";
            lblDiscountAmonut.Size = new Size(13, 15);
            lblDiscountAmonut.TabIndex = 9;
            lblDiscountAmonut.Text = "0";
            // 
            // lblTextProcent
            // 
            lblTextProcent.AutoSize = true;
            lblTextProcent.Location = new Point(683, 385);
            lblTextProcent.Name = "lblTextProcent";
            lblTextProcent.Size = new Size(17, 15);
            lblTextProcent.TabIndex = 11;
            lblTextProcent.Text = "%";
            // 
            // FormShopCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTextProcent);
            Controls.Add(lblTextDiscount);
            Controls.Add(lblDiscountAmonut);
            Controls.Add(txtBoxPromocode);
            Controls.Add(btnInputPromocode);
            Controls.Add(btnDeleteProd);
            Controls.Add(lblTextSumProd);
            Controls.Add(lblSumProducts);
            Controls.Add(btnPayAllProducts);
            Controls.Add(btnPayProduct);
            Controls.Add(listBoxShopCart);
            Name = "FormShopCart";
            Text = "Корзина товаров";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxShopCart;
        private Button btnPayAllProducts;
        private Button btnPayProduct;
        private Label lblTextSumProd;
        private Label lblSumProducts;
        private Button btnDeleteProd;
        private Button btnInputPromocode;
        private TextBox txtBoxPromocode;
        private Label lblTextDiscount;
        private Label lblDiscountAmonut;
        private Label lblTextProcent;
    }
}