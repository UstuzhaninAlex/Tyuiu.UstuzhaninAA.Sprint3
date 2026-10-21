using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task6.V3.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;
            int wait = 121; // Математически результат

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
