using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task7.V17.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            // Ожидаемый массив значений, рассчитанный по формуле
            double[] wait = new double[11];
            wait[0] = 14.41;
            wait[1] = -1.25;
            wait[2] = -21.43;
            wait[3] = -12.18;
            wait[4] = -7.42;
            wait[5] = -6.00;
            wait[6] = -8.53;
            wait[7] = 0.99;
            wait[8] = 17.53;
            wait[9] = 1.05;
            wait[10] = -16.14;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверка равенства двух массивов
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
