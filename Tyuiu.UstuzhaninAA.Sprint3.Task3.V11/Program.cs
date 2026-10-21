using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task3.V11.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string str = "sqwreq vqwqq q";

            Console.Title = "Спринт #3 | Выполнил: Устюжанин А.А. | Задание 3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке:            *");
            Console.WriteLine("* sqwreq vqwqq q                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            // Вызываем метод с тремя параметрами
            string resultStr = ds.ReplaceCharOnNum(str, 'q', '7');
            Console.WriteLine($"Строка после замены: {resultStr}");

            Console.ReadKey();
        }
    }
}
