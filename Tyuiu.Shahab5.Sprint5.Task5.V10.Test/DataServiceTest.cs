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

            Directory.CreateDirectory(@"C:\DataSprint5\");
            File.WriteAllText(path, "2\n4\n6\n8\n2");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(22.0, result);
        }
    }
}