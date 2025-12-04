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

            // Путь к файлу с данными
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            Console.Title = "Спринт #5 | Выполнил: Шабаев М.С. | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Шабаев Матвей Сергеевич | АСОиУБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V5.txt в котором есть       *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить в       *");
            Console.WriteLine("* формулу y = (4.26*x)/sin(x). Вычислить значение и вернуть результат.    *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
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

            // Читаем значение x из файла
            string strX = File.ReadAllText(path);
            Console.WriteLine($"Значение x из файла: {strX}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Вычисляем результат
                double res = ds.LoadFromDataFile(path);

                // Выводим вычисления
                double x = Convert.ToDouble(strX.Replace('.', ','));
                Console.WriteLine($"Формула: y = (4.26 * {x}) / sin({x})");
                Console.WriteLine($"Результат: {res}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль (sin(x) = 0)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}