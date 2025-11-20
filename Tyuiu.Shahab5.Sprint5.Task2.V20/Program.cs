using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task2.V20.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шахаб А. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1, *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите 9 элементов массива 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(matrix);

            // Чтение результата из файла и вывод на консоль
            string[] fileContent = File.ReadAllLines(path);

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("Обработанный массив:");
            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}