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
    public partial class frmAddCategoryAdmin : Form
    {
        public frmAddCategoryAdmin()
        {
            InitializeComponent();
        }

        private void frmAddCategoryAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tblCategory", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SqlConnection con = new SqlConnection(Config.ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into tblCategory (CategoryName)values ('" + txtcategoryname.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Inserted");
            }
        }
        #region Private Method

        private bool IsValidate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtcategoryname.Text))
            {
                errorcategory.SetError(txtcategoryname, "Enter category name");
                isValid = false;
            }
            else
            {
                errorcategory.SetError(txtcategoryname, "");
            }


            return isValid;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            txtcategoryname.Text = "";
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                SqlConnection con = new SqlConnection(Config.ConnectionString);
                SqlCommand cmd = new SqlCommand("delete tblCategory where CategoryName = '" + txtcategoryname.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Deleted Successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
