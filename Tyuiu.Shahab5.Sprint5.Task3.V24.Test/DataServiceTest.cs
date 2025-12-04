using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task3.V24.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileBinaryData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileBinaryData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidFileContent()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileBinaryData(3);

            double valueFromFile = 0;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                valueFromFile = reader.ReadDouble();
            }

            double expected = 67 * Math.Pow(3, 3) + 0.23 * Math.Pow(3, 2) + 1.04 * 3;
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, valueFromFile);
        }
    }
}