namespace WinFormsApp9
{
    partial class FormUserListProduct
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
            listBoxProducts = new ListBox();
            btnAddProdShopCart = new Button();
            lblSumProducts = new Label();
            lblTextSumProd = new Label();
            SuspendLayout();
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(12, 12);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(776, 394);
            listBoxProducts.TabIndex = 0;
            // 
            // btnAddProdShopCart
            // 
            btnAddProdShopCart.Location = new Point(286, 415);
            btnAddProdShopCart.Name = "btnAddProdShopCart";
            btnAddProdShopCart.Size = new Size(175, 23);
            btnAddProdShopCart.TabIndex = 1;
            btnAddProdShopCart.Text = "Добавить товар в корзину";
            btnAddProdShopCart.UseVisualStyleBackColor = true;
            btnAddProdShopCart.Click += btnAddProdShopCart_Click;
            // 
            // lblSumProducts
            // 
            lblSumProducts.AutoSize = true;
            lblSumProducts.Location = new Point(647, 426);
            lblSumProducts.Name = "lblSumProducts";
            lblSumProducts.Size = new Size(13, 15);
            lblSumProducts.TabIndex = 2;
            lblSumProducts.Text = "0";
            // 
            // lblTextSumProd
            // 
            lblTextSumProd.AutoSize = true;
            lblTextSumProd.Location = new Point(545, 426);
            lblTextSumProd.Name = "lblTextSumProd";
            lblTextSumProd.Size = new Size(96, 15);
            lblTextSumProd.TabIndex = 3;
            lblTextSumProd.Text = "Текущая сумма:";
            // 
            // FormUserListProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTextSumProd);
            Controls.Add(lblSumProducts);
            Controls.Add(btnAddProdShopCart);
            Controls.Add(listBoxProducts);
            Name = "FormUserListProduct";
            Text = "`";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProducts;
        private Button btnAddProdShopCart;
        private Label lblSumProducts;
        private Label lblTextSumProd;
    }
}