namespace WinFormsApp9
{
    partial class FormPurchaseHistory
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
            listBoxPurchaseHistory = new ListBox();
            SuspendLayout();
            // 
            // listBoxPurchaseHistory
            // 
            listBoxPurchaseHistory.FormattingEnabled = true;
            listBoxPurchaseHistory.ItemHeight = 15;
            listBoxPurchaseHistory.Location = new Point(12, 12);
            listBoxPurchaseHistory.Name = "listBoxPurchaseHistory";
            listBoxPurchaseHistory.Size = new Size(776, 424);
            listBoxPurchaseHistory.TabIndex = 1;
            // 
            // FormPurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPurchaseHistory);
            Name = "FormPurchaseHistory";
            Text = "FormPurchaseHistory";
            Load += FormPurchaseHistory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPurchaseHistory;
    }
}