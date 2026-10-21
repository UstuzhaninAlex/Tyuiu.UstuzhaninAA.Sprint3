using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            // Внешний цикл
            for (int x = startValue; x <= stopValue; x++)
            {
                // Внутренний цикл для поиска делителей текущего числа x
                for (int d = 1; d <= x; d++)
                {
                    // Если x делится на d без остатка и делитель строго больше 8
                    if (x % d == 0 && d > 8)
                    {
                        sum += d; // Суммируем делитель
                    }
                }
            }

            return sum;
        }
    }
}
