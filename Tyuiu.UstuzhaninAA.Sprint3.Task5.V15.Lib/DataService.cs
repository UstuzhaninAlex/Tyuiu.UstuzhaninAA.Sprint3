using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sumSeries = 0;

            // Внешний цикл по переменной i
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл по переменной k
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Вычисление члена ряда и добавление к общей сумме
                    sumSeries += Math.Sin(x) + (Math.Pow(k, 2) / 2.0);
                }
            }

            // Округление результата до 3 знаков после запятой
            return Math.Round(sumSeries, 3);
        }
    }
}

