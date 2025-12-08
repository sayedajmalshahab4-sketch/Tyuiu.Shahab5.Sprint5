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
            Assert.IsTrue(fileExists);
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

            // Правильный расчет для формулы F(x) = 6.1x^3 + 0.23x^2 + 1.04x
            double expected = 6.1 * Math.Pow(3, 3) + 0.23 * Math.Pow(3, 2) + 1.04 * 3;
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, valueFromFile);
        }

        [TestMethod]
        public void ValidBase64Encoding()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileBinaryData(3);

            byte[] fileBytes = File.ReadAllBytes(path);
            string base64 = Convert.ToBase64String(fileBytes);

            // Ожидаемый base64 для значения 169.89
            string expectedBase64 = "FK5H4Xo8ZUA=";

            Assert.AreEqual(expectedBase64, base64);
        }
    }
}