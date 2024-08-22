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
    public partial class frmReportAdmin : Form
    {
        public frmReportAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tblProduct where Qty between '" + less.Text + "' and '" + gre.Text + "'", con);

            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
