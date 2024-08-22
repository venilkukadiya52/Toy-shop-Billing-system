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
    public partial class frmAddProductAdmin : Form
    {
        SqlConnection con = new SqlConnection(Config.ConnectionString);
        public frmAddProductAdmin()
        {
            InitializeComponent();
        }

        private void frmAddProductAdmin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblProduct",con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblProduct where ProductName='"+txtname.Text+"'", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
