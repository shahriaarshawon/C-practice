namespace FormLogginApp
{
    partial class Form1
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
            this.lblUserNameForm1 = new System.Windows.Forms.Label();
            this.lblPasswordForm1 = new System.Windows.Forms.Label();
            this.lblDepartmentForm1 = new System.Windows.Forms.Label();
            this.lblDateofBirthForm1 = new System.Windows.Forms.Label();
            this.lblGenderForm1 = new System.Windows.Forms.Label();
            this.btnNextForm1 = new System.Windows.Forms.Button();
            this.txtUserNameForm1 = new System.Windows.Forms.TextBox();
            this.txtPasswordForm1 = new System.Windows.Forms.TextBox();
            this.cmbForm1 = new System.Windows.Forms.ComboBox();
            this.dateTimeForm1 = new System.Windows.Forms.DateTimePicker();
            this.rbMaleForm1 = new System.Windows.Forms.RadioButton();
            this.rbFemaleForm1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblUserNameForm1
            // 
            this.lblUserNameForm1.AutoSize = true;
            this.lblUserNameForm1.Location = new System.Drawing.Point(58, 85);
            this.lblUserNameForm1.Name = "lblUserNameForm1";
            this.lblUserNameForm1.Size = new System.Drawing.Size(63, 13);
            this.lblUserNameForm1.TabIndex = 0;
            this.lblUserNameForm1.Text = "User Name ";
            // 
            // lblPasswordForm1
            // 
            this.lblPasswordForm1.AutoSize = true;
            this.lblPasswordForm1.Location = new System.Drawing.Point(58, 129);
            this.lblPasswordForm1.Name = "lblPasswordForm1";
            this.lblPasswordForm1.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordForm1.TabIndex = 1;
            this.lblPasswordForm1.Text = "Password";
            // 
            // lblDepartmentForm1
            // 
            this.lblDepartmentForm1.AutoSize = true;
            this.lblDepartmentForm1.Location = new System.Drawing.Point(58, 170);
            this.lblDepartmentForm1.Name = "lblDepartmentForm1";
            this.lblDepartmentForm1.Size = new System.Drawing.Size(62, 13);
            this.lblDepartmentForm1.TabIndex = 2;
            this.lblDepartmentForm1.Text = "Department";
            // 
            // lblDateofBirthForm1
            // 
            this.lblDateofBirthForm1.AutoSize = true;
            this.lblDateofBirthForm1.Location = new System.Drawing.Point(58, 213);
            this.lblDateofBirthForm1.Name = "lblDateofBirthForm1";
            this.lblDateofBirthForm1.Size = new System.Drawing.Size(66, 13);
            this.lblDateofBirthForm1.TabIndex = 3;
            this.lblDateofBirthForm1.Text = "Date of Birth";
            // 
            // lblGenderForm1
            // 
            this.lblGenderForm1.AutoSize = true;
            this.lblGenderForm1.Location = new System.Drawing.Point(58, 251);
            this.lblGenderForm1.Name = "lblGenderForm1";
            this.lblGenderForm1.Size = new System.Drawing.Size(42, 13);
            this.lblGenderForm1.TabIndex = 4;
            this.lblGenderForm1.Text = "Gender";
            // 
            // btnNextForm1
            // 
            this.btnNextForm1.Location = new System.Drawing.Point(234, 319);
            this.btnNextForm1.Name = "btnNextForm1";
            this.btnNextForm1.Size = new System.Drawing.Size(75, 23);
            this.btnNextForm1.TabIndex = 5;
            this.btnNextForm1.Text = "Next";
            this.btnNextForm1.UseVisualStyleBackColor = true;
            this.btnNextForm1.Click += new System.EventHandler(this.btnNextForm1_Click);
            // 
            // txtUserNameForm1
            // 
            this.txtUserNameForm1.Location = new System.Drawing.Point(139, 82);
            this.txtUserNameForm1.Name = "txtUserNameForm1";
            this.txtUserNameForm1.Size = new System.Drawing.Size(200, 20);
            this.txtUserNameForm1.TabIndex = 6;
            this.txtUserNameForm1.TextChanged += new System.EventHandler(this.txtUserNameForm1_TextChanged);
            // 
            // txtPasswordForm1
            // 
            this.txtPasswordForm1.Location = new System.Drawing.Point(139, 126);
            this.txtPasswordForm1.Name = "txtPasswordForm1";
            this.txtPasswordForm1.Size = new System.Drawing.Size(200, 20);
            this.txtPasswordForm1.TabIndex = 7;
            this.txtPasswordForm1.TextChanged += new System.EventHandler(this.txtPasswordForm1_TextChanged);
            // 
            // cmbForm1
            // 
            this.cmbForm1.FormattingEnabled = true;
            this.cmbForm1.Location = new System.Drawing.Point(139, 167);
            this.cmbForm1.Name = "cmbForm1";
            this.cmbForm1.Size = new System.Drawing.Size(200, 21);
            this.cmbForm1.TabIndex = 8;
            this.cmbForm1.SelectedIndexChanged += new System.EventHandler(this.cmbForm1_SelectedIndexChanged);
            // 
            // dateTimeForm1
            // 
            this.dateTimeForm1.Location = new System.Drawing.Point(139, 206);
            this.dateTimeForm1.Name = "dateTimeForm1";
            this.dateTimeForm1.Size = new System.Drawing.Size(200, 20);
            this.dateTimeForm1.TabIndex = 9;
            this.dateTimeForm1.ValueChanged += new System.EventHandler(this.dateTimeForm1_ValueChanged);
            // 
            // rbMaleForm1
            // 
            this.rbMaleForm1.AutoSize = true;
            this.rbMaleForm1.Location = new System.Drawing.Point(118, 247);
            this.rbMaleForm1.Name = "rbMaleForm1";
            this.rbMaleForm1.Size = new System.Drawing.Size(48, 17);
            this.rbMaleForm1.TabIndex = 10;
            this.rbMaleForm1.TabStop = true;
            this.rbMaleForm1.Text = "Male";
            this.rbMaleForm1.UseVisualStyleBackColor = true;
            // 
            // rbFemaleForm1
            // 
            this.rbFemaleForm1.AutoSize = true;
            this.rbFemaleForm1.Location = new System.Drawing.Point(118, 270);
            this.rbFemaleForm1.Name = "rbFemaleForm1";
            this.rbFemaleForm1.Size = new System.Drawing.Size(59, 17);
            this.rbFemaleForm1.TabIndex = 11;
            this.rbFemaleForm1.TabStop = true;
            this.rbFemaleForm1.Text = "Female";
            this.rbFemaleForm1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(445, 388);
            this.Controls.Add(this.rbFemaleForm1);
            this.Controls.Add(this.rbMaleForm1);
            this.Controls.Add(this.dateTimeForm1);
            this.Controls.Add(this.cmbForm1);
            this.Controls.Add(this.txtPasswordForm1);
            this.Controls.Add(this.txtUserNameForm1);
            this.Controls.Add(this.btnNextForm1);
            this.Controls.Add(this.lblGenderForm1);
            this.Controls.Add(this.lblDateofBirthForm1);
            this.Controls.Add(this.lblDepartmentForm1);
            this.Controls.Add(this.lblPasswordForm1);
            this.Controls.Add(this.lblUserNameForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameForm1;
        private System.Windows.Forms.Label lblPasswordForm1;
        private System.Windows.Forms.Label lblDepartmentForm1;
        private System.Windows.Forms.Label lblDateofBirthForm1;
        private System.Windows.Forms.Label lblGenderForm1;
        private System.Windows.Forms.Button btnNextForm1;
        private System.Windows.Forms.TextBox txtUserNameForm1;
        private System.Windows.Forms.TextBox txtPasswordForm1;
        private System.Windows.Forms.ComboBox cmbForm1;
        private System.Windows.Forms.DateTimePicker dateTimeForm1;
        private System.Windows.Forms.RadioButton rbMaleForm1;
        private System.Windows.Forms.RadioButton rbFemaleForm1;
    }
}

