using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task2.V20.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { 5, -5, -1 },
                { -4, 2, -4 },
                { -7, 1, 4 }
            };
            string path = ds.SaveToFileTextData(matrix);

            // Проверка существования файла
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверка содержимого файла
            string[] fileContent = File.ReadAllLines(path);
            string[] wait = {
                "1;0;0",
                "0;1;0",
                "0;1;1"
            };

            CollectionAssert.AreEqual(wait, fileContent);
        }
    }
}