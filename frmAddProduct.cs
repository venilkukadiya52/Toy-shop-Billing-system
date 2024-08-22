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
    public partial class frmAddProduct : Form
    {
        SqlConnection con = new SqlConnection(Config.ConnectionString);

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tblProduct (ProductName,Price,Qty) values ('"+txtpname.Text+"','"+txtprice.Text+"','"+txtqty.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtpname.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tblProduct set Price='" + txtprice.Text + "' , Qty='" + txtqty.Text + "' where ProductName='" + txtpname.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete tblProduct where ProductName='" + txtpname.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
