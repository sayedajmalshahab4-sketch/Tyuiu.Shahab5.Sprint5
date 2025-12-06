using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab5.Sprint5.Task7.V25.Lib;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            // Создаем тестовый входной файл
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V25.txt";

            // Создаем папку, если её нет
            Directory.CreateDirectory(Path.GetDirectoryName(inputPath));

            // Записываем тестовый текст в файл
            string testText = "Hello world! This is test 123. Привет мир! Apple orange.";
            File.WriteAllText(inputPath, testText);

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            // Проверяем, что выходной файл создан
            Assert.IsTrue(File.Exists(outputPath));

            // Читаем результат
            string resultText = File.ReadAllText(outputPath);

            // В результате должны остаться только не-английские слова
            // Ожидается: "!  123. Привет мир! ." (английские слова удалены)
            string expected = "!  123. Привет мир! .";

            Assert.AreEqual(expected, resultText);
        }

        [TestMethod]
        public void ValidInputFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V25.txt";
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void ValidOnlyEnglishWords()
        {
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V25.txt";
            File.WriteAllText(inputPath, "Hello World Test");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            string resultText = File.ReadAllText(outputPath);

            // После удаления всех английских слов должна быть пустая строка
            Assert.AreEqual("", resultText);
        }
    }
}