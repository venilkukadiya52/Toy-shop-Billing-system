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
    public partial class frmSeleProductAdmin : Form
    {
        public frmSeleProductAdmin()
        {
            InitializeComponent();
        }

        private void cmbproduct_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select Price,Qty from tblProduct where ProductName='" + cmbproduct.Text + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtprice.Text = reader[0].ToString();
                txtstock.Text = reader[1].ToString();
            }



            con.Close();

        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            txttotalprice.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into tblSaleProduct (Name,Price,Qty,totalprice,custname,contactno,address,SaleDate) values ('" + cmbproduct.Text + "','" + txtprice.Text + "','" + txtqty.Text + "','" + txttotalprice.Text + "','" + txtcustname.Text + "','" + txtcontactno.Text + "','" + txtaddress.Text + "','" + txtdate.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(txtstock.Text) - Convert.ToInt32(txtqty.Text);

            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("update tblProduct set Qty='" + qty + "' where ProductName='" + cmbproduct.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();

            txtstock.Text = qty.ToString();



            con.Close();
            MessageBox.Show("Product Sale");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttotalprice.Text = "";
            txtstock.Text = "";
            txtqty.Text = "";
            txtprice.Text = "";
            txtcustname.Text = "";
            txtcontactno.Text = "";
            txtaddress.Text = "";
            cmbproduct.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            price.Text = txtprice.Text.ToString();
            Qty.Text = txtqty.Text.ToString();
            custname.Text = txtcustname.Text.ToString();
            totalamount.Text = txttotalprice.Text.ToString();
            Productname.Text = cmbproduct.Text.ToString();
        }

        private void frmSeleProductAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tblProduct", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            txtdate.Text = Convert.ToDateTime(DateTime.Now.ToString()).ToString("mm/dd/yyyy");
            con.Close();

        }
    }
}
