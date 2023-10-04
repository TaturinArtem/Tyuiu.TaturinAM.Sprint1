using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint1.Task2.V7.Lib;
namespace Tyuiu.TaturinAM.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresslon()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSideSquare(x);
            Assert.AreEqual(4, res);

        }
    }
}
