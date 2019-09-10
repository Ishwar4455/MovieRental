using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class UnitTestCase
    {
        public int AddTwoPostiveNumber(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return -1;
            }
            return a + b;
        }
        public bool ValidateDBConnectionSctring()
        {
            DAL sqlConn = new DAL();
            sqlConn.fwDALConnection();
            return true;
        }
    }
}
