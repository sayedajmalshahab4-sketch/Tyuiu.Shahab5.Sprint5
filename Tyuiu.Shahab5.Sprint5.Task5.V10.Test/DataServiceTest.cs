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
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            File.WriteAllText(path, "2\n4\n6\n8\n2");

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);

            double wait = 22.0;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void ValidWithDecimalNumbers()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            File.WriteAllText(path, "2.0\n4.0\n6.0\n8.0\n2.0");

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(22.0, res);
        }
    }
}