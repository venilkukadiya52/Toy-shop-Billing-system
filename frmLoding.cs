using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Toy_Shop
{
    public partial class frmLoding : Form
    {
        public frmLoding()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 9;

            if (panel2.Width >= 525)
            {
                timer1.Stop();
                this.Hide();
                //MessageBox.Show("Hello It's Done");
                frmUsersChoice objchoice = new frmUsersChoice();
                objchoice.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
