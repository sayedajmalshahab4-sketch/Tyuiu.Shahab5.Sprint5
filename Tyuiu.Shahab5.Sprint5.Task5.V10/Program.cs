using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task5.V10.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил:Шахаб | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил:  Шахаб| АСОиУБ-25-1                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор значений. Найти сумму всех четных        *");
            Console.WriteLine("* целых чисел в файле. У вещественных значений округлить до трёх знаков   *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";

            Console.WriteLine($"Файл: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine($"Сумма всех четных целых чисел в файле = {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}