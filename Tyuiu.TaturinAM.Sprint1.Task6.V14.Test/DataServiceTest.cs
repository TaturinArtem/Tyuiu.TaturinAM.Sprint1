using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint1.Task6.V14.Lib;

namespace Tyuiu.TaturinAM.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "Привет";
            bool res = ds.CheckLowerCaseRusLetters(value);
            Assert.IsFalse(res);
        }
    }
}
