namespace WinFormsApp9
{
    partial class FormAddAccessories
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
            btnAddProd = new Button();
            cmbBoxTypeProd = new ComboBox();
            txtBoxProdName = new TextBox();
            txtBoxProdPrice = new TextBox();
            txtBoxProdDescription = new TextBox();
            SuspendLayout();
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(190, 346);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(333, 23);
            btnAddProd.TabIndex = 0;
            btnAddProd.Text = "Добавить";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // cmbBoxTypeProd
            // 
            cmbBoxTypeProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxTypeProd.FormattingEnabled = true;
            cmbBoxTypeProd.Items.AddRange(new object[] { "Процессор", "Видеокарта", "Оперативная память", "Материнская плата", "Блок питания", "Корпус", "SSD", "SSD M.2", "HDD", "Охлаждение", "Монитор" });
            cmbBoxTypeProd.Location = new Point(190, 31);
            cmbBoxTypeProd.Name = "cmbBoxTypeProd";
            cmbBoxTypeProd.Size = new Size(333, 23);
            cmbBoxTypeProd.TabIndex = 1;
            // 
            // txtBoxProdName
            // 
            txtBoxProdName.Location = new Point(190, 60);
            txtBoxProdName.Name = "txtBoxProdName";
            txtBoxProdName.PlaceholderText = "Название";
            txtBoxProdName.Size = new Size(333, 23);
            txtBoxProdName.TabIndex = 2;
            // 
            // txtBoxProdPrice
            // 
            txtBoxProdPrice.Location = new Point(190, 89);
            txtBoxProdPrice.Name = "txtBoxProdPrice";
            txtBoxProdPrice.PlaceholderText = "Цена";
            txtBoxProdPrice.Size = new Size(333, 23);
            txtBoxProdPrice.TabIndex = 3;
            // 
            // txtBoxProdDescription
            // 
            txtBoxProdDescription.Location = new Point(190, 118);
            txtBoxProdDescription.Multiline = true;
            txtBoxProdDescription.Name = "txtBoxProdDescription";
            txtBoxProdDescription.PlaceholderText = "Описание товара";
            txtBoxProdDescription.Size = new Size(333, 213);
            txtBoxProdDescription.TabIndex = 4;
            // 
            // FormAddAccessories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxProdDescription);
            Controls.Add(txtBoxProdPrice);
            Controls.Add(txtBoxProdName);
            Controls.Add(cmbBoxTypeProd);
            Controls.Add(btnAddProd);
            Name = "FormAddAccessories";
            Text = "Добавление комплектующих";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProd;
        private ComboBox cmbBoxTypeProd;
        private TextBox txtBoxProdName;
        private TextBox txtBoxProdPrice;
        private TextBox txtBoxProdDescription;
    }
}