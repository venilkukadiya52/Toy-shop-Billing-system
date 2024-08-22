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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into tblCustomer (CustomerName,Contactno,Emailid,Address)values ('" + txtname.Text + "','" + txtcontactno.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtcontactno.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("update tblCustomer set CustomerName='" + txtname.Text + "',Emailid='" + txtemail.Text + "',Contactno='" + txtcontactno.Text + "',Address='" + txtaddress.Text + "' where Id='" + Logininfo.ID + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("delete tblCustomer where CustomerName='"+txtname.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tblCustomer ", con);
            con.Open();
            DataTable dt =new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource=dt;
           
            con.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer c = new frmCustomer();
            
            c.Show();
        }
    }
}
