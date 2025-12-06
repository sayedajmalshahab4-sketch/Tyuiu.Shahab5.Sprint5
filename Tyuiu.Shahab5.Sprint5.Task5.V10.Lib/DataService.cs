using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Shahab5.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public DataService()
        {
        }

        public double LoadFromDataFile(string path)
        {
            double sum = 0;

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    // Парсим число, учитывая разные форматы (с точкой или запятой)
                    string normalizedLine = line.Trim();
                    normalizedLine = normalizedLine.Replace('.', ',');

                    if (double.TryParse(normalizedLine, NumberStyles.Any,
                        CultureInfo.GetCultureInfo("ru-RU"), out double number))
                    {
                        // Проверяем, является ли число целым
                        if (Math.Abs(number - Math.Round(number)) < 0.0001)
                        {
                            int intNumber = (int)Math.Round(number);

                            // Проверяем четность
                            if (intNumber % 2 == 0)
                            {
                                sum += intNumber;
                            }
                        }
                    }
                }
                catch
                {
                    // Игнорируем строки, которые не являются числами
                    continue;
                }
            }

            return sum;
        }
    }
}