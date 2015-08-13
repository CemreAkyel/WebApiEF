using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test.DAL.Migrations.TestClass tc = new Test.DAL.Migrations.TestClass();
            tc.Seeder(new Test.DAL.EntityManager.TestDbContext());
        }
    }
}
