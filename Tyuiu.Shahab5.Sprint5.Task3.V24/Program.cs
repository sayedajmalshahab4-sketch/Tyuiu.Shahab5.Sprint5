using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task3.V24.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 6x⁴ + 0.23x² + 1.04x, вычислить его значение     *");
            Console.WriteLine("* при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin     *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);

            // Чтение результата из бинарного файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine($"Значение функции F({x}) = {result}");

            // Также выводим Base64 для проверки
            byte[] fileBytes = File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(fileBytes);
            Console.WriteLine($"Base64 представление: {base64String}");

            Console.ReadKey();
        }
    }
}