using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task7.V17.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #3 | Выполнил: Устюжанин А. А. | Задание 7";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x) = (sin(x)/(x+1.7)) - cos(x)*4x - 6 на диапазоне [-5; 5]            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     X     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");

            // Вызов метода табулирования функции
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            int x = startValue;
            for (int i = 0; i < valueArray.Length; i++)
            {
                // Форматированный структурированный вывод таблицы в консоль
                Console.WriteLine("| {0,5}     | {1,7:F2}   |", x, valueArray[i]);
                x++;
            }
            Console.WriteLine("+-----------+-----------+");

            Console.ReadKey();
        }
    }
}
