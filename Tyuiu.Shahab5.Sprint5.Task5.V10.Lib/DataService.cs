using System;
using System.IO;
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

            string text = File.ReadAllText(path);
            string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string cleanLine = line.Trim();
                if (string.IsNullOrEmpty(cleanLine)) continue;

                
                cleanLine = cleanLine.Replace('.', ',');

                if (double.TryParse(cleanLine, out double number))
                {
                    
                    number = Math.Round(number, 3);

                    
                    if (Math.Abs(number % 1) < 0.0001)
                    {
                        int intNum = (int)Math.Round(number);

                        
                        if (intNum % 2 == 0)
                        {
                            sum += intNum;
                        }
                    }
                }
            }

            return sum;
        }
    }
}