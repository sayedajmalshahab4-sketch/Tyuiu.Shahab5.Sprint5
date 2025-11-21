using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task5.V10.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V10.txt");

            string[] testData = {
                "2.5",
                "4",
                "6.0",
                "7.3",
                "8",
                "10.2",
                "12",
                "3.7"
            };
            File.WriteAllLines(path, testData);

            double result = ds.LoadFromDataFile(path);
            double wait = 30; // 4 + 6 + 8 + 12 = 30

            Assert.AreEqual(wait, result);

            File.Delete(path);
        }
    }
}