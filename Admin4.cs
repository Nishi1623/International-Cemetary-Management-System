using System;
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
    public partial class Admin4 : Form
    {
        public Admin4()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin5 m1 = new Admin5();
            this.Hide();
            m1.Show();
        }
    }
}
