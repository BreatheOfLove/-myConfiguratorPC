namespace WinFormsApp9
{
    partial class FormAddPromocode
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
            txtBoxPromocode = new TextBox();
            cmbBoxDiscoutAmount = new ComboBox();
            btnAddNewPromocode = new Button();
            SuspendLayout();
            // 
            // txtBoxPromocode
            // 
            txtBoxPromocode.Location = new Point(268, 57);
            txtBoxPromocode.Name = "txtBoxPromocode";
            txtBoxPromocode.PlaceholderText = "Промокод";
            txtBoxPromocode.Size = new Size(146, 23);
            txtBoxPromocode.TabIndex = 0;
            // 
            // cmbBoxDiscoutAmount
            // 
            cmbBoxDiscoutAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxDiscoutAmount.FormatString = "%";
            cmbBoxDiscoutAmount.FormattingEnabled = true;
            cmbBoxDiscoutAmount.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "50", "75", "100" });
            cmbBoxDiscoutAmount.Location = new Point(268, 86);
            cmbBoxDiscoutAmount.Name = "cmbBoxDiscoutAmount";
            cmbBoxDiscoutAmount.Size = new Size(146, 23);
            cmbBoxDiscoutAmount.TabIndex = 1;
            // 
            // btnAddNewPromocode
            // 
            btnAddNewPromocode.Location = new Point(268, 115);
            btnAddNewPromocode.Name = "btnAddNewPromocode";
            btnAddNewPromocode.Size = new Size(146, 23);
            btnAddNewPromocode.TabIndex = 2;
            btnAddNewPromocode.Text = "Создать промик";
            btnAddNewPromocode.UseVisualStyleBackColor = true;
            btnAddNewPromocode.Click += btnAddNewPromocode_Click;
            // 
            // FormAddPromocode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNewPromocode);
            Controls.Add(cmbBoxDiscoutAmount);
            Controls.Add(txtBoxPromocode);
            Name = "FormAddPromocode";
            Text = "Панель создания промика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPromocode;
        private ComboBox cmbBoxDiscoutAmount;
        private Button btnAddNewPromocode;
    }
}