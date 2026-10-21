using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Вычисляем размер массива
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (x + 1.7 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    
                    double y = (Math.Sin(x) / (x + 1.7)) - Math.Cos(x) * 4 * x - 6;

                    // Запись в массив с округлением до двух знаков после запятой
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
