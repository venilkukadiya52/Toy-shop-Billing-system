using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Toy_Shop
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
                SqlConnection con = new SqlConnection(Config.ConnectionString);
                SqlCommand cmd = new SqlCommand("update tblRegistration set Password = '" + txtnewpassword.Text + "',ConPassword='" + txtconfirmpassword.Text + "' where ID='" + Logininfo.ID + "'", con);
                con.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                if (i > 1)
                {
                    MessageBox.Show("Your Password Was Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Password Not Changed");
                }

                this.Close();
            
        }
    }
}
