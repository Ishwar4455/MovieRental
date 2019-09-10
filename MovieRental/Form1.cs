using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class Form1 : Form
    {
        BAL bl = new BAL();
        public Form1()
        {
            InitializeComponent();
          
        }
        /// <summary>
        /// Login Credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@userid", txtLogin.Text);

            sp[1] = new SqlParameter("@pwd", txtPassword.Text);
            dt = bl.getExecutSP_DTWithParamter("userLogin", sp);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    this.Hide();
                    Movie _movie = new Movie();
                    _movie.ShowDialog();
                   
                }
               
            }
            else
            {
                txtLogin.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Login ID and Password is invalid.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
