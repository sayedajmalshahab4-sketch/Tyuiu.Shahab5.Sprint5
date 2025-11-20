using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public DataService()
        {
        }

        public double LoadFromDataFile(string path)
        {
            // Чтение значения из файла
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);

            // Вычисление значения функции (пример формулы)
            // ЗДЕСЬ НУЖНО ЗАМЕНИТЬ ФОРМУЛУ НА НУЖНУЮ
            double y = Math.Pow(x, 2) + Math.Sin(x) + 2.5;
            y = Math.Round(y, 3);

            return y;
        }
    }
}