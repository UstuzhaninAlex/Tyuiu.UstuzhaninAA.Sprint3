using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task2.V30.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double x = 0.25;
            int startValue = 1;
            int stopValue = 11;

            // Вычисление метода
            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            // Ожидаемое значение после перемножения 11 элементов
            double wait = 3986.353;

            // Проверка
            Assert.AreEqual(wait, res);
        }
    }
}
