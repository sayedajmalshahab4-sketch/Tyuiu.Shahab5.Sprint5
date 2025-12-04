using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab5.Sprint5.Task4.V5.Lib;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Создаем тестовый файл с данными
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            // Создаем папку, если её нет
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Записываем тестовое значение в файл
            File.WriteAllText(path, "2.5");

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);

            // Проверяем результат для x = 2.5
            double x = 2.5;
            double wait = Math.Round((4.26 * x) / Math.Sin(x), 3);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }
    }
}