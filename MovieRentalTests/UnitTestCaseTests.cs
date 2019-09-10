using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MovieRental.Tests
{
    [TestClass()]
    public class UnitTestCaseTests
    {
        [TestMethod()]
        public void AddTwoPostiveNumberTest()
        {
            UnitTestCase customLogic = new UnitTestCase();
            var result = customLogic.AddTwoPostiveNumber(10, 20);
            Assert.IsTrue(result == 30);
        }
        [TestMethod()]
        public void CheckDbConnConfig()
        {
            UnitTestCase customLogic = new UnitTestCase();
            var result = customLogic.ValidateDBConnectionSctring();
            Assert.IsTrue(result);

        }
    }
}