using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task4.V10.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            // Вызов метода
            double res = ds.Calculate(startValue, stopValue);

            // Ожидаемый результат перемножения всех точек
            double wait = -0.019;

            Assert.AreEqual(wait, res);
        }
    }
}
