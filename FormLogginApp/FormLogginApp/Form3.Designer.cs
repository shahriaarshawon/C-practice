namespace FormLogginApp
{
    partial class Form3
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
            this.lblUserNameForm3 = new System.Windows.Forms.Label();
            this.lblPasswordForm3 = new System.Windows.Forms.Label();
            this.txtUserNameform3 = new System.Windows.Forms.TextBox();
            this.txtPasswordForm3 = new System.Windows.Forms.TextBox();
            this.btnLoginForm3 = new System.Windows.Forms.Button();
            this.btnCancelForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserNameForm3
            // 
            this.lblUserNameForm3.AutoSize = true;
            this.lblUserNameForm3.Location = new System.Drawing.Point(126, 84);
            this.lblUserNameForm3.Name = "lblUserNameForm3";
            this.lblUserNameForm3.Size = new System.Drawing.Size(60, 13);
            this.lblUserNameForm3.TabIndex = 0;
            this.lblUserNameForm3.Text = "User Name";
            // 
            // lblPasswordForm3
            // 
            this.lblPasswordForm3.AutoSize = true;
            this.lblPasswordForm3.Location = new System.Drawing.Point(126, 128);
            this.lblPasswordForm3.Name = "lblPasswordForm3";
            this.lblPasswordForm3.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordForm3.TabIndex = 1;
            this.lblPasswordForm3.Text = "Password";
            // 
            // txtUserNameform3
            // 
            this.txtUserNameform3.Location = new System.Drawing.Point(211, 84);
            this.txtUserNameform3.Name = "txtUserNameform3";
            this.txtUserNameform3.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameform3.TabIndex = 2;
            // 
            // txtPasswordForm3
            // 
            this.txtPasswordForm3.Location = new System.Drawing.Point(211, 125);
            this.txtPasswordForm3.Name = "txtPasswordForm3";
            this.txtPasswordForm3.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordForm3.TabIndex = 3;
            // 
            // btnLoginForm3
            // 
            this.btnLoginForm3.Location = new System.Drawing.Point(157, 227);
            this.btnLoginForm3.Name = "btnLoginForm3";
            this.btnLoginForm3.Size = new System.Drawing.Size(75, 23);
            this.btnLoginForm3.TabIndex = 4;
            this.btnLoginForm3.Text = "Login";
            this.btnLoginForm3.UseVisualStyleBackColor = true;
            // 
            // btnCancelForm3
            // 
            this.btnCancelForm3.Location = new System.Drawing.Point(285, 227);
            this.btnCancelForm3.Name = "btnCancelForm3";
            this.btnCancelForm3.Size = new System.Drawing.Size(75, 23);
            this.btnCancelForm3.TabIndex = 5;
            this.btnCancelForm3.Text = "Cancel";
            this.btnCancelForm3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(512, 367);
            this.Controls.Add(this.btnCancelForm3);
            this.Controls.Add(this.btnLoginForm3);
            this.Controls.Add(this.txtPasswordForm3);
            this.Controls.Add(this.txtUserNameform3);
            this.Controls.Add(this.lblPasswordForm3);
            this.Controls.Add(this.lblUserNameForm3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameForm3;
        private System.Windows.Forms.Label lblPasswordForm3;
        private System.Windows.Forms.TextBox txtUserNameform3;
        private System.Windows.Forms.TextBox txtPasswordForm3;
        private System.Windows.Forms.Button btnLoginForm3;
        private System.Windows.Forms.Button btnCancelForm3;
    }
}