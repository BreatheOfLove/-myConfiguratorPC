namespace WinFormsApp9
{
    partial class MainForm
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
            lblRoleUser = new Label();
            lblTextRole = new Label();
            SuspendLayout();
            // 
            // lblLoginUser
            // 
            lblLoginUser.AutoSize = true;
            lblLoginUser.Location = new Point(582, 9);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(41, 15);
            lblLoginUser.TabIndex = 10;
            lblLoginUser.Text = "Логин";
            lblLoginUser.Visible = false;
            // 
            // lblRoleUser
            // 
            lblRoleUser.AutoSize = true;
            lblRoleUser.Location = new Point(660, 9);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(39, 15);
            lblRoleUser.TabIndex = 11;
            lblRoleUser.Text = "никто";
            // 
            // lblTextRole
            // 
            lblTextRole.AutoSize = true;
            lblTextRole.Location = new Point(638, 9);
            lblTextRole.Name = "lblTextRole";
            lblTextRole.Size = new Size(26, 15);
            lblTextRole.TabIndex = 12;
            lblTextRole.Text = "Вы:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTextRole);
            Controls.Add(lblRoleUser);
            Controls.Add(lblLoginUser);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLoginUser;
        private Label lblRoleUser;
        private Label lblTextRole;
    }
}
