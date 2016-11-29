using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToneAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneAnalyzer.Tests
{
    [TestClass()]
    public class DashboardDataAccessTests
    {
        [TestMethod()]
        public void CreateSqLiteDatabase()
        {
            DashboardDataAccess db = new DashboardDataAccess();
            db.FileName = System.IO.Path.GetTempFileName();
            db.CreateSchema();
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void InsertSqLiteDatabase()
        {
            DashboardDataAccess db = new DashboardDataAccess();
            db.FileName = System.IO.Path.GetTempFileName();
            db.CreateSchema();
            db.AddEmail(1, "Inbox", new EmailAnalysis(), "", "hi", DateTime.Now, "High", false, "Hank", "Hank@Tasks.org");
            Assert.IsTrue(true);
        }
    }
}