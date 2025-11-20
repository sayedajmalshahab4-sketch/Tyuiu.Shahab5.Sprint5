using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task1.V24.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileBinaryData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileBinaryData(x);

            // Проверка существования файла
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверка содержимого файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            double wait = 15.641; // Ожидаемое значение для формулы x² + sin(x) + 2.5x - 1.5 при x=3
            Assert.AreEqual(wait, result);
        }
    }
}