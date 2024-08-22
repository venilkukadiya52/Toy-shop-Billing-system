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
    public partial class frmProfileAdmin : Form
    {
        public frmProfileAdmin()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("update tblAdminLogin set UserName='" + txtusername.Text + "',Address='" + txtaddress.Text + "',Email='" + txtemailid.Text + "',Contactno='" + txtcontactno.Text + "' where Id='" + Logininfo.ID + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtusername.Text = reader[0].ToString();
                txtaddress.Text = reader[1].ToString();
                txtemailid.Text = reader[2].ToString();
                txtcontactno.Text = reader[3].ToString();

            }


            MessageBox.Show("Parofile Updated Successfully");
            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProfileAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select UserName,Address,Email,Contactno from tblAdminLogin where Id='" + Logininfo.ID + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtusername.Text = reader[0].ToString();
                txtaddress.Text = reader[1].ToString();
                txtemailid.Text = reader[2].ToString();
                txtcontactno.Text = reader[3].ToString();

            }



            con.Close();
        }
    }
}
