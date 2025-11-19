using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public DataService()
        {
        }

        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Вычисление значения функции
            double y = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;
            y = Math.Round(y, 3);

            // Запись результата в файл
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(y);
            }

            return path;
        }
    }
}