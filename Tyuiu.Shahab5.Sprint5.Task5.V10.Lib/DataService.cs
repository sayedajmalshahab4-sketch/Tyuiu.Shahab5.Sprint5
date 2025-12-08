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
            string[] lines = File.ReadAllLines(path);
            double sum = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string cleanLine = line.Trim();

                if (TryParseNumber(cleanLine, out double number))
                {
                    number = Math.Round(number, 3, MidpointRounding.AwayFromZero);

                    if (Math.Abs(number - Math.Round(number)) < 0.0001)
                    {
                        int intValue = (int)Math.Round(number);

                        if (intValue % 2 == 0)
                        {
                            sum += intValue;
                        }
                    }
                }
            }

            return sum;
        }

        private bool TryParseNumber(string str, out double result)
        {
            result = 0;

            if (double.TryParse(str, NumberStyles.Float | NumberStyles.AllowThousands,
                CultureInfo.InvariantCulture, out result))
            {
                return true;
            }

            if (double.TryParse(str, NumberStyles.Float | NumberStyles.AllowThousands,
                new CultureInfo("ru-RU"), out result))
            {
                return true;
            }

            string modified = str.Replace('.', ',');
            if (double.TryParse(modified, NumberStyles.Float | NumberStyles.AllowThousands,
                new CultureInfo("ru-RU"), out result))
            {
                return true;
            }

            modified = str.Replace(',', '.');
            if (double.TryParse(modified, NumberStyles.Float | NumberStyles.AllowThousands,
                CultureInfo.InvariantCulture, out result))
            {
                return true;
            }

            return false;
        }
    }
}