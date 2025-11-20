using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task4.V5.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создание временного файла с тестовыми данными
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            // Создание директории, если она не существует
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Запись тестового значения в файл
            File.WriteAllText(path, "3.14");

            double result = ds.LoadFromDataFile(path);
            double wait = 12.865; // Ожидаемое значение для формулы x² + sin(x) + 2.5 при x=3.14

            Assert.AreEqual(wait, result);
        }
    }
}