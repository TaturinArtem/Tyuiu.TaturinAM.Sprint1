using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint1.Task7.V20.Lib;
namespace Tyuiu.TaturinAM.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double wait = -2.046;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
