using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab5.Sprint5.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Создаем тестовый файл с данными
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";

            // Создаем папку, если её нет
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Записываем тестовую строку в файл
            string testString = "Hello world! This is a test string with 5 english words.";
            File.WriteAllText(path, testString);

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);

            // В строке: Hello, world, This, is, a, test, string, with, english, words = 10 слов
            int wait = 10;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void ValidEmptyString()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";
            File.WriteAllText(path, "");

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, res);
        }
    }
}