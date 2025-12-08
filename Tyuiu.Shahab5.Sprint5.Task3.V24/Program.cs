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

            int x = 3;

            Console.Title = "Спринт #5 | Выполнил:Шахаб . | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шахаб | АСОиУБ-25-1                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 6.1x^3 + 0.23x^2 + 1.04x, вычислить его значение  *");
            Console.WriteLine("* при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и    *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Сохраняем в файл
            string path = ds.SaveToFileBinaryData(x);

            // Читаем и выводим значение из файла
            double result = 0;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            // Также вычисляем для проверки
            double calculated = 6.1 * Math.Pow(3, 3) + 0.23 * Math.Pow(3, 2) + 1.04 * 3;
            calculated = Math.Round(calculated, 3);

            Console.WriteLine($"Результат вычислений: {calculated}");
            Console.WriteLine($"Результат из файла: {result}");
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");

            // Дополнительно: покажем файл в base64 для проверки
            byte[] fileBytes = File.ReadAllBytes(path);
            string base64 = Convert.ToBase64String(fileBytes);
            Console.WriteLine($"Base64 файла: {base64}");

            Console.ReadKey();
        }
    }
}