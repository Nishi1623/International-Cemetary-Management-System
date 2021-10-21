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
    public partial class Admin3 : Form
    {
        public Admin3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Admin4 m1 = new Admin4();
            this.Hide();
            m1.Show();
        }
    }
}
