using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toy_Shop
{
    public partial class frmUsersChoice : Form
    {
        public frmUsersChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin o = new frmLogin();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUserLogin o = new frmUserLogin();
            o.Show();
        }
    }
}
