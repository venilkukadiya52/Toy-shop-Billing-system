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
    public partial class frmRegistrationNewUser : Form
    {
        public frmRegistrationNewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtconpass.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
            txtshopname.Text = "";
            txtusername.Text = "";
        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into tblRegistration (ShopName,UserName,Password,ConPassword,Contactno,Emailid) Values ('" + txtshopname.Text + "','" + txtusername.Text + "','" + txtpass.Text + "','" + txtconpass.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registrer Successfully");
        }
    }
}
