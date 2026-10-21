using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.Title = "Спринт #3 | Выполнил: Устюжанин А.А. | Задание 5";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму двойного ряда функции       *");
            Console.WriteLine("* при X = 5.                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение X = {x}");
            Console.WriteLine($"Старт шага первого ряда = {startValue1}");
            Console.WriteLine($"Конец шага первого ряда = {stopValue1}");
            Console.WriteLine($"Старт шага второго ряда = {startValue2}");
            Console.WriteLine($"Конец шага второго ряда = {stopValue2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Console.WriteLine($"Сумма двойного ряда = {res}");

            Console.ReadKey();
        }
    }
}
