using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task0.V20.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 2;
            string path = ds.SaveToFileTextData(x);

            // Проверка существования файла
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверка содержимого файла
            string fileContent = File.ReadAllText(path).Trim();
            string wait = "37.56";
            Assert.AreEqual(wait, fileContent);
        }
    }
}