using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;



/// <summary>
/// Summary description for login
/// </summary>
namespace MovieRental
{
    public class DAL
    {
        String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString();
        SqlConnection sqlConn = new SqlConnection();

        public SqlConnection fwDALConnection()
        {
            sqlConn = new SqlConnection(appsetting);
            return sqlConn;

        }
        public void SqlOpen()
        {
            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {

            }


        }
        public void SqlClose()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}