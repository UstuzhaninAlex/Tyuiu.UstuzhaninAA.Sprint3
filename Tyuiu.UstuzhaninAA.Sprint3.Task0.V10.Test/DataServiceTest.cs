using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task0.V10.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 1;
            int stopValue = 5;

            
            double wait = 0.003;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
