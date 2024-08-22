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
    public partial class frmUserProfile : Form
    {
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("update tblRegistration set UserName='" + txtusername.Text + "',Address='" + txtaddress.Text + "',Emailid='" + txtemailid.Text + "',Contactno='" + txtcontactno.Text + "' where Id='" + Logininfo.ID + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtshopname.Text = reader[0].ToString();
                txtusername.Text = reader[1].ToString();
                txtaddress.Text = reader[2].ToString();
                txtemailid.Text = reader[3].ToString();
                txtcontactno.Text = reader[4].ToString();

            }


            MessageBox.Show("Parofile Updated Successfully");
            con.Close();
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            SqlCommand cmd = new SqlCommand("select ShopName,UserName,Address,Emailid,Contactno from tblRegistration where Id='" + Logininfo.ID + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtshopname.Text = reader[0].ToString();
                txtusername.Text = reader[1].ToString();
                txtaddress.Text = reader[2].ToString();
                txtemailid.Text = reader[3].ToString();
                txtcontactno.Text = reader[4].ToString();

            }



            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
