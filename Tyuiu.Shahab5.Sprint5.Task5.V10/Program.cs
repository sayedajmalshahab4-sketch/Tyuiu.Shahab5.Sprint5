using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task5.V10.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Путь к файлу с данными
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V10.txt");

            Console.Title = "Спринт #5 | Выполнил:  Шахаб| АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Шахаб | АСОиУБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V10.txt в котором есть      *");
            Console.WriteLine("* набор значений. Найти сумму всех четных целых чисел в файле.            *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Путь к файлу: {path}");

            // Проверяем существование файла
            if (!File.Exists(path))
            {
                Console.WriteLine("ОШИБКА: Файл не найден!");
                Console.WriteLine("Создайте папку C:\\DataSprint5\\ и поместите туда файл InPutDataFileTask5V10.txt");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }

            // Читаем и выводим содержимое файла
            Console.WriteLine("\nСОДЕРЖИМОЕ ФАЙЛА:");
            Console.WriteLine("----------------------------------------");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисляем сумму четных целых чисел
                double result = ds.LoadFromDataFile(path);

                // Выводим результат
                Console.WriteLine($"Сумма всех четных целых чисел в файле = {result}");

                // Если ожидается 22.0, давайте проверим какие числа были в файле
                Console.WriteLine("\nАНАЛИЗ:");
                AnalyzeFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }

        static void AnalyzeFile(string path)
        {
            double sum = 0;
            Console.WriteLine("Найденные четные целые числа:");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string normalizedLine = line.Trim().Replace('.', ',');

                if (double.TryParse(normalizedLine, out double number))
                {
                    if (Math.Abs(number % 1) < 0.0001)
                    {
                        int intNumber = (int)Math.Round(number);
                        if (intNumber % 2 == 0)
                        {
                            Console.WriteLine($"  {intNumber}");
                            sum += intNumber;
                        }
                    }
                }
            }
            Console.WriteLine($"Итого сумма: {sum}");
        }
    }
}