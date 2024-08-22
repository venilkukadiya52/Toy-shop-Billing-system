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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer o = new frmCustomer();
            o.MdiParent = this;
            o.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword o= new frmChangePassword();
            o.MdiParent = this;
            o.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserProfile o = new frmUserProfile();
            o.MdiParent = this;
            o.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomerReport o = new frmCustomerReport();
            o.MdiParent=this;
            o.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleProduct o = new frmSaleProduct();
            o.MdiParent = this;
            o.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProductAdmin o = new frmAddProductAdmin();
            o.MdiParent = this;
            o.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmUserLogin o = new frmUserLogin();
            o.Show();
        }
    }
}
