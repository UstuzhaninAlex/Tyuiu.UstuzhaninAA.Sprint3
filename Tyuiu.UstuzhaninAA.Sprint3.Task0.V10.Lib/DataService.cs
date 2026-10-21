using System;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UstuzhaninAA.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int x, int startValue, int stopValue)
        {
            // Начальное значение  должно быть 1
            double multiplySeries = 1.0;

            
            for (int t = startValue; t <= stopValue; t++)
            {
                
                multiplySeries *= Math.Pow(300.0 / (t + Math.Pow(x, t)), t);
            }

            // Округляем до 3 знаков после запятой 
            return Math.Round(multiplySeries, 3);
        }
    }
}
