using System;
using System.IO;
using Tyuiu.Shahab5.Sprint5.Task0.V20.Lib;

namespace Tyuiu.Shahab5.Sprint5.Task0.V20
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-25-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.12x^3 + 1.05x^2 + 4.1x * 2. Вычислить его      *");
            Console.WriteLine("* значение при x = 2, результат сохранить в текстовый файл               *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков     *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine($"x = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);

            // Чтение результата из файла и вывод на консоль
            string fileContent = File.ReadAllText(path);
            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine($"Значение функции F({x}) = {fileContent}");

            Console.ReadKey();
        }
    }
}