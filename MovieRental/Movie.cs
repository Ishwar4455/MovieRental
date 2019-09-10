using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class Movie : Form
    {
        BAL bl = new BAL();
        public Movie()
        {
            InitializeComponent();
            FillCustomerList();
            FillMovieList();
            FillRentalList();
        }

        private void FillCustomerList()
        {
            DataTable dt = new DataTable();
            dt = bl.getExecutSP_DTWithoutParamter("sp_GetCustomerList");
            dataGridView1.DataSource = dt;

        }
        private void FillMovieList()
        {
            DataTable dt = new DataTable();
            dt = bl.getExecutSP_DTWithoutParamter("sp_GetMovieList");
            dataGridView2.DataSource = dt;

        }
        private void FillRentalList()
        {
            DataTable dt = new DataTable();
            dt = bl.getExecutSP_DTWithoutParamter("sp_GetRentalList");
            dataGridView3.DataSource = dt;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// add customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@FirstName", txtCustomerFName.Text);
            sp[1] = new SqlParameter("@LastName", txtCustomerLName.Text);
            sp[2] = new SqlParameter("@Address", txtAddress.Text);
            sp[3] = new SqlParameter("@Phone", txtPhone.Text);
            bl.getExecutSP_DTWithParamter("sp_InsertUpdateCustomer", sp);
            FillCustomerList();
            MessageBox.Show("Customer updated successfully");

        }
        /// <summary>
        /// Update Customers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@FirstName", txtCustomerFName.Text);
            sp[1] = new SqlParameter("@LastName", txtCustomerLName.Text);
            sp[2] = new SqlParameter("@Address", txtAddress.Text);
            sp[3] = new SqlParameter("@Phone", txtPhone.Text);
            sp[4] = new SqlParameter("@CustID", txtCustomerID.Text);
            bl.getExecutSP_DTWithParamter("sp_InsertUpdateCustomer", sp);
            txtCustomerID.Text = "";
            txtCustomerFName.Text = "";
            txtCustomerLName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            FillCustomerList();
            MessageBox.Show("Customer updated successfully");
        }
        /// <summary>
        /// Save Movies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@Title", textBox7.Text);
            sp[1] = new SqlParameter("@Rental_Cost", txtRentalCost.Text);
            sp[2] = new SqlParameter("@Genre", txtGenre.Text);
            sp[3] = new SqlParameter("@Plot", txtPlot.Text);
            bl.getExecutSP_DTWithParamter("sp_InsertUpdateMovies", sp);
            FillMovieList();
            MessageBox.Show("Movie saved successfully");
        }
        /// <summary>
        /// Update Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@Title", textBox7.Text);
            sp[1] = new SqlParameter("@Rental_Cost", txtRentalCost.Text);
            sp[2] = new SqlParameter("@Genre", txtGenre.Text);
            sp[3] = new SqlParameter("@Plot", txtPlot.Text);
            sp[4] = new SqlParameter("@MovieID", txtMovieID.Text);
            bl.getExecutSP_DTWithParamter("sp_InsertUpdateMovies", sp);
            FillMovieList();
            MessageBox.Show("Movie updated successfully");
        }
        /// <summary>
        /// Delete Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@movieID", txtMovieID.Text);
            bl.getExecutSP_DTWithParamter("sp_DeleteMovies", sp);
            FillMovieList();
            MessageBox.Show("Movie deleted successfully");
        }
        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@customerID", txtCustomerID.Text);
            bl.getExecutSP_DTWithParamter("sp_DeleteCustomers", sp);
            FillCustomerList();
            MessageBox.Show("Customer deleted successfully");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtCustomerID.Text = row.Cells[0].Value.ToString();
                txtCustomerFName.Text = row.Cells[1].Value.ToString();
                txtCustomerLName.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMovieID.Text = row.Cells[0].Value.ToString();
                textBox7.Text = row.Cells[1].Value.ToString();
                txtGenre.Text = row.Cells[2].Value.ToString();
                txtRentalCost.Text = row.Cells[3].Value.ToString();
                txtPlot.Text = row.Cells[4].Value.ToString();
            }
        }

        /// <summary>
        /// Return Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalID", txtRentalID.Text);
            bl.getExecutSP_DTWithParamter("sp_UpdateRentalReturnMovie", sp);
            FillRentalList();
            MessageBox.Show("Movie returned by the customer");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtRentalID.Text = row.Cells[0].Value.ToString();
                txtCustomerFName.Text = row.Cells[1].Value.ToString();
                txtCustomerLName.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                textBox7.Text = row.Cells[4].Value.ToString();
                txtRentalCost.Text = row.Cells[5].Value.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "A");
            dt = bl.getExecutSP_DTWithParamter("GetMoviesRentalList", sp);
            dataGridView3.DataSource = dt;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "O");
            dt = bl.getExecutSP_DTWithParamter("GetMoviesRentalList", sp);
            dataGridView3.DataSource = dt;
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@customerID", txtCustomerID.Text);
            sp[1] = new SqlParameter("@movieID", txtMovieID.Text);
            bl.getExecutSP_DTWithParamter("sp_InsertRentalIssueMovie", sp);
            FillRentalList();
            MessageBox.Show("Movie rented to the customer");

        }
    }
}
