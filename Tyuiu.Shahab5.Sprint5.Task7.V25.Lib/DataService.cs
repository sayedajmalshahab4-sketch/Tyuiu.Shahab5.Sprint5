using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

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

            // Удаляем английские слова
            string pattern = @"\b[a-zA-Z]+\b";
            string resultText = Regex.Replace(inputText, pattern, "");

            // Убираем лишние пробелы более аккуратно
            resultText = CleanSpaces(resultText);

            // Создаем путь для выходного файла
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V25.txt");

            // Сохраняем результат в выходной файл
            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }

        private string CleanSpaces(string text)
        {
            // Убираем множественные пробелы
            text = Regex.Replace(text, @"\s+", " ");

            // Убираем пробелы перед знаками препинания
            text = Regex.Replace(text, @"\s+([.,!?;:])", "$1");

            // Убираем пробелы после знаков препинания (кроме случаев, когда это нужно)
            text = Regex.Replace(text, @"([.,!?;:])\s+", "$1 ");

            return text.Trim();
        }
    }
}