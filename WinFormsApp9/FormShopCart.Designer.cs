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
            btnPayProduct = new Button();
            btnPayAllProducts = new Button();
            SuspendLayout();
            // 
            // listBoxShopCart
            // 
            listBoxShopCart.FormattingEnabled = true;
            listBoxShopCart.ItemHeight = 15;
            listBoxShopCart.Location = new Point(87, 21);
            listBoxShopCart.Name = "listBoxShopCart";
            listBoxShopCart.Size = new Size(607, 319);
            listBoxShopCart.TabIndex = 0;
            // 
            // btnPayProduct
            // 
            btnPayProduct.Location = new Point(304, 358);
            btnPayProduct.Name = "btnPayProduct";
            btnPayProduct.Size = new Size(121, 23);
            btnPayProduct.TabIndex = 1;
            btnPayProduct.Text = "Оплатить товар";
            btnPayProduct.UseVisualStyleBackColor = true;
            btnPayProduct.Click += btnPayProduct_Click;
            // 
            // btnPayAllProducts
            // 
            btnPayAllProducts.Location = new Point(304, 397);
            btnPayAllProducts.Name = "btnPayAllProducts";
            btnPayAllProducts.Size = new Size(121, 23);
            btnPayAllProducts.TabIndex = 2;
            btnPayAllProducts.Text = "Оплатить корзину";
            btnPayAllProducts.UseVisualStyleBackColor = true;
            // 
            // FormShopCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPayAllProducts);
            Controls.Add(btnPayProduct);
            Controls.Add(listBoxShopCart);
            Name = "FormShopCart";
            Text = "Корзина товаров";
            Load += FormShopCart_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxShopCart;
        private Button btnPayProduct;
        private Button btnPayAllProducts;
    }
}