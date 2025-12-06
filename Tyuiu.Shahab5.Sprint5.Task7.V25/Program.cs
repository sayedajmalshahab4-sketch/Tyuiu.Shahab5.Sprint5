using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task7.V25.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Путь к входному файлу
            string inputPath = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V25.txt");

            Console.Title = "Спринт #5 | Выполнил:   Шахаб| АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шахаб | АСОиУБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V25.txt в котором есть      *");
            Console.WriteLine("* набор символьных данных. Удалить все английские слова из файла.         *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V25.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Входной файл: {inputPath}");

            // Проверяем существование входного файла
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("ОШИБКА: Файл не найден!");
                Console.WriteLine("Создайте папку C:\\DataSprint5\\ и поместите туда файл InPutDataFileTask7V25.txt");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }

            // Читаем и выводим исходный текст
            string originalText = File.ReadAllText(inputPath);
            Console.WriteLine("\nИСХОДНЫЙ ТЕКСТ:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(originalText);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Обрабатываем файл
                string outputPath = ds.LoadDataAndSave(inputPath);

                // Читаем и выводим результат
                string resultText = File.ReadAllText(outputPath);
                Console.WriteLine("ТЕКСТ ПОСЛЕ УДАЛЕНИЯ АНГЛИЙСКИХ СЛОВ:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(resultText);
                Console.WriteLine("----------------------------------------");

                Console.WriteLine($"\nРезультат сохранен в файл: {outputPath}");
                Console.WriteLine("Файл успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}