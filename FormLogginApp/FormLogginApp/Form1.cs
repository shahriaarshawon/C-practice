﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNextForm1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Visible = true;
            this.Visible = false;
        }

        private void txtUserNameForm1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordForm1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbForm1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeForm1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
