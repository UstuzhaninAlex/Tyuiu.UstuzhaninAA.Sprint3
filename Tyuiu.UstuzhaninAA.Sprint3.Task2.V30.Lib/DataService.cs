using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UstuzhaninAA.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double x, int startValue, int stopValue)
        {
            // Начальное значение
            double multiplySeries = 1.0;

            // Счетчика цикла
            int i = startValue;

            // Выполнение цикла с постусловием
            do
            {
                
                multiplySeries *= (Math.Pow(x, 2) * i) + 2;

                // Переход к следующему шагу
                i++;
            }
            while (i <= stopValue); // Условие для продолжения цикла

            // Округление результата до 3 знаков после запятой
            return Math.Round(multiplySeries, 3);
        }
    }
}
