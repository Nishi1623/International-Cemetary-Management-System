﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin2 m1 = new Admin2();
            this.Hide();
            m1.Show();
        }
    }
}
