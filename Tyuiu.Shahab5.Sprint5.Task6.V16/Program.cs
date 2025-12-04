using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task6.V16.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Путь к файлу с данными
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V16.txt");

            Console.Title = "Спринт #5 | Выполнил: Шабаев М.С. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Шабаев Матвей Сергеевич | АСОиУБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V16.txt в котором есть      *");
            Console.WriteLine("* набор символьных данных. Найти количество английских слов в строке.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Путь к файлу: {path}");

            // Проверяем существование файла
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Создайте папку C:\\DataSprint5\\ и поместите туда файл.");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }

            // Читаем содержимое файла
            string fileContent = File.ReadAllText(path);
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(fileContent);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисляем результат
                int res = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество английских слов в строке = {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}