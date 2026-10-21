using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            
            double wait = 548.732;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Assert.AreEqual(wait, res);
        }
    }
}
