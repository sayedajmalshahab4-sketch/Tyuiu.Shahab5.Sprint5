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

            Console.Title = "Спринт #5 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с вещественным значением. Прочитать значение и подставить     *");
            Console.WriteLine("* вместо x в формуле y = (4.26 * x) / sin(x). Вычислить значение и       *");
            Console.WriteLine("* вернуть результат на консоль. Округлить до трёх знаков после запятой.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V5.txt");

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "2.0");
            }

            Console.WriteLine($"Путь к файлу: {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Значение функции y = {result}");

            Console.ReadKey();
        }
    }
}