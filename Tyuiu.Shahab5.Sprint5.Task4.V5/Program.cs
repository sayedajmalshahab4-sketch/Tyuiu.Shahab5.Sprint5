using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task4.V5.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шахаб А. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V5.txt в котором есть       *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо *");
            Console.WriteLine("* x в формуле. Вычислить значение и вернуть полученный результат на      *");
            Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            // Проверка существования файла
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не существует! Создаем тестовый файл...");
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(path, "2.5"); // Тестовое значение
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Значение функции = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}