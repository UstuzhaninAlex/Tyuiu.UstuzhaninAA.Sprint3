using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint3.Task3.V11.Lib;


namespace Tyuiu.UstuzhaninAA.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            // Подготовка данных
            DataService ds = new DataService();
            string str = "sqwreq vqwqq q";
            char item = 'q';      // Что ищем
            char element = '7';   // На что меняем
            string wait = "s7wre7 v7w77 7"; // Ожидаемый результат

            // Выполнение метода с тремя параметрами
            string res = ds.ReplaceCharOnNum(str, item, element);

            // Проверка
            Assert.AreEqual(wait, res);
        }
    }
}
