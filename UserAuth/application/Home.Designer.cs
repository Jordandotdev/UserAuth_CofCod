using System.ComponentModel;

namespace UserAuth.application
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(31, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(120, 22);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(192, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(526, 341);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "Home";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblUser;

        private System.Windows.Forms.Label lblPassword;
        
        #endregion
    }
}