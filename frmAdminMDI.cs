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
    public partial class frmAdminMDI : Form
    {
        public frmAdminMDI()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct co = new frmAddProduct();
            co.MdiParent = this;
            co.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeleProductAdmin o = new frmSeleProductAdmin();
            o.MdiParent=this;
            o.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCategoryAdmin o = new frmAddCategoryAdmin();
            o.MdiParent = this;
            o.Show();
        }

        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswor o = new frmChangePasswor();
            o.MdiParent = this;
            o.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfileAdmin o = new frmProfileAdmin();
            o.MdiParent = this;
            o.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin o = new frmLogin();
            o.Show();
        }

        private void quantityWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportAdmin o = new frmReportAdmin();
            o.MdiParent = this;
            o.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer o = new frmCustomer();
            o.MdiParent = this;
            o.Show();
        }

        private void customerWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReport o = new frmCustomerReport();
            o.MdiParent = this;
            o.Show();
        }

        private void addNewUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRegistrationNewUser o = new frmRegistrationNewUser();
            o.MdiParent = this;
            o.Show();
        }

       /*private void customerWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReport o = new frmCustomerReport();
            o.MdiParent = this;
            o.Show();
        }*/
    }
}
