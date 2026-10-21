using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UstuzhaninAA.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int x, int startValue, int stopValue)
        {
            // Начальное значение для произведения
            double multiplySeries = 1.0;

            // Счетчика цикла
            int k = startValue;

            // Выполнение цикла while, пока счетчик не превысит конечное значение
            while (k <= stopValue)
            {
                
                multiplySeries *= (Math.Cos(x) + (double)k / 4.0);

                // Инкремент счетчика (переход к следующему шагу)
                k++;
            }

            // Округление результата до 3 знаков после запятой
            return Math.Round(multiplySeries, 3);
        }
    }
}
