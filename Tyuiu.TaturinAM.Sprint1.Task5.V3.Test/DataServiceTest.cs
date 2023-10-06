using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint1.Task5.V3.Lib;
namespace Tyuiu.TaturinAM.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 130985;
            int expected = 9;

            int result = ds.Calculate(k);

            Assert.AreEqual(expected, result);
        }
    }
}
