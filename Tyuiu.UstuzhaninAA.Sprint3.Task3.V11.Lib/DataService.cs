using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UstuzhaninAA.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        
        public string ReplaceCharOnNum(string value, char item, char element)
        {
            StringBuilder result = new StringBuilder();

            foreach (char ch in value)
            {
                // Сравниваем с переменной
                if (ch == item)
                {
                    // Добавляем переменную 
                    result.Append(element);
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
