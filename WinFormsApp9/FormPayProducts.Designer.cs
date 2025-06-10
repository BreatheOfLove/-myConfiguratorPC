namespace WinFormsApp9
{
    partial class FormPayProducts
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
            btnCheckPay = new Button();
            btnCancelPay = new Button();
            pictureBoxQRCodePay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCodePay).BeginInit();
            SuspendLayout();
            // 
            // btnCheckPay
            // 
            btnCheckPay.Location = new Point(227, 342);
            btnCheckPay.Name = "btnCheckPay";
            btnCheckPay.Size = new Size(143, 23);
            btnCheckPay.TabIndex = 0;
            btnCheckPay.Text = "Проверить оплату";
            btnCheckPay.UseVisualStyleBackColor = true;
            btnCheckPay.Click += btnCheckPay_Click;
            // 
            // btnCancelPay
            // 
            btnCancelPay.Location = new Point(433, 342);
            btnCancelPay.Name = "btnCancelPay";
            btnCancelPay.Size = new Size(117, 23);
            btnCancelPay.TabIndex = 1;
            btnCancelPay.Text = "Отмена";
            btnCancelPay.UseVisualStyleBackColor = true;
            btnCancelPay.Click += btnCancelPay_Click;
            // 
            // pictureBoxQRCodePay
            // 
            pictureBoxQRCodePay.Location = new Point(49, 35);
            pictureBoxQRCodePay.Name = "pictureBoxQRCodePay";
            pictureBoxQRCodePay.Size = new Size(676, 282);
            pictureBoxQRCodePay.TabIndex = 2;
            pictureBoxQRCodePay.TabStop = false;
            // 
            // FormPayProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxQRCodePay);
            Controls.Add(btnCancelPay);
            Controls.Add(btnCheckPay);
            Name = "FormPayProducts";
            Text = "Форма оплаты";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCodePay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckPay;
        private Button btnCancelPay;
        private PictureBox pictureBoxQRCodePay;
    }
}