namespace FormLogginApp
{
    partial class Form4
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
            this.lblWelcomeform4 = new System.Windows.Forms.Label();
            this.btnLogoutForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeform4
            // 
            this.lblWelcomeform4.AutoSize = true;
            this.lblWelcomeform4.Location = new System.Drawing.Point(153, 112);
            this.lblWelcomeform4.Name = "lblWelcomeform4";
            this.lblWelcomeform4.Size = new System.Drawing.Size(52, 13);
            this.lblWelcomeform4.TabIndex = 0;
            this.lblWelcomeform4.Text = "Welcome";
            // 
            // btnLogoutForm4
            // 
            this.btnLogoutForm4.Location = new System.Drawing.Point(156, 191);
            this.btnLogoutForm4.Name = "btnLogoutForm4";
            this.btnLogoutForm4.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutForm4.TabIndex = 1;
            this.btnLogoutForm4.Text = "Logout";
            this.btnLogoutForm4.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(391, 346);
            this.Controls.Add(this.btnLogoutForm4);
            this.Controls.Add(this.lblWelcomeform4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeform4;
        private System.Windows.Forms.Button btnLogoutForm4;
    }
}