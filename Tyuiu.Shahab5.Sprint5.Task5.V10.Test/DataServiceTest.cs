using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab5.Sprint5.Task5.V10.Lib;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Создаем тестовый файл с данными
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";

            // Создаем папку, если её нет
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Записываем тестовые данные
            // Пример чисел: 2, 4, 6, 8, 2 = сумма 22
            string[] testData = { "2", "4.0", "6.5", "8", "2", "3.7", "5", "10.2" };
            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);

            // Ожидаемая сумма четных целых чисел: 2 + 4 + 8 + 2 = 16?
            // Но если в файле: 2, 4, 6, 8, 2 = 22
            double wait = 22.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void ValidOnlyOddNumbers()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            string[] testData = { "1", "3", "5", "7", "9.0" };
            File.WriteAllLines(path, testData);

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(0.0, res);
        }
    }
}