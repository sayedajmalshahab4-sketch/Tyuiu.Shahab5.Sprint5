using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.Shahab5.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public DataService()
        {
        }

        public string LoadDataAndSave(string path)
        {
            // Читаем весь текст из входного файла
            string inputText = File.ReadAllText(path);

            // Используем регулярное выражение для удаления английских слов
            // Английские слова: последовательность букв a-z или A-Z
            string pattern = @"\b[a-zA-Z]+\b";
            string resultText = Regex.Replace(inputText, pattern, "");

            // Убираем лишние пробелы, которые могли образоваться
            resultText = Regex.Replace(resultText, @"\s+", " ");
            resultText = resultText.Trim();

            // Создаем путь для выходного файла
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V25.txt");

            // Сохраняем результат в выходной файл
            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }
    }
}