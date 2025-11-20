using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task3.V24.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            // Проверка существования файла
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверка содержимого файла через Base64
            byte[] fileBytes = File.ReadAllBytes(path);
            string resultBase64 = Convert.ToBase64String(fileBytes);
            string wait = "FK5H4Xo8ZUA=";

            Assert.AreEqual(wait, resultBase64);
        }
    }
}