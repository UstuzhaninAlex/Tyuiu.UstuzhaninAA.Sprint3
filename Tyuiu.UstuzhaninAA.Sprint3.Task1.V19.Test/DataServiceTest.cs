using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task1.V19.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int x = 1;
            int startValue = 1;
            int stopValue = 9;

            // Вычисление метода
            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            // Ожидаемое значение
            double wait = 60.125;

            // Проверка
            Assert.AreEqual(wait, res);
        }
    }
}
