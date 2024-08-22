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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        
        }
        #region Private Method

        private bool IsValidate()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                error_username.SetError(txt_username, "Enter Username");
                isValid = false;
            }
            else
            {
                error_username.SetError(txt_username, "");
            }

            if (string.IsNullOrEmpty(txt_password.Text))
            {
                isValid = false;
                error_password.SetError(txt_password, "Enter Password");
            }
            else
            {
                error_password.SetError(txt_username, "");
            }
            return isValid;
        }
        #endregion
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {


                SqlConnection con = new SqlConnection(Config.ConnectionString);

                SqlCommand cmd = new SqlCommand("select ID from tblAdminLogin where UserName='" + Convert.ToString(txt_username.Text) + "' and Password='" + Convert.ToString(txt_password.Text) + "'", con);

                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                if (id > 0)
                {

                    //MessageBox.Show("Loggin Done..");
                    Logininfo.ID = id;
                    
                    this.Hide();
                   var mdiObj = new frmAdminMDI();
                    mdiObj.Show();
                   
                }
                else
                {
                    MessageBox.Show("Please Enter valid Username And Password");
                }


            }
        }

        private void lbl_login_heading_Click(object sender, EventArgs e)
        {

        }
    }
}
