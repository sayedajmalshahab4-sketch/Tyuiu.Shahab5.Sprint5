using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Shahab5.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public DataService()
        {
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = 3 * x + 1.2;

                    // Проверка деления на ноль
                    if (Math.Abs(denominator) < 0.0001)
                    {
                        writer.WriteLine("0.00");
                        continue;
                    }

                    // Вычисление функции: F(x) = (2sin(x))/(3x+1.2) + cos(x) - 7x * 2
                    double value = (2 * Math.Sin(x)) / denominator + Math.Cos(x) - 14 * x;

                    // Округление до двух знаков
                    writer.WriteLine($"{value:F2}");
                }
            }

            return path;
        }
    }
}