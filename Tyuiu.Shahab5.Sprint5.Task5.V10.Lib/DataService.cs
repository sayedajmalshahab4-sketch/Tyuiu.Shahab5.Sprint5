using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

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

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (double.TryParse(line, out double number))
                {
                    if (number == Math.Floor(number) && number % 2 == 0)
                    {
                        sum += number;
                    }
                }
            }

            return Math.Round(sum, 3);
        }
    }
}



