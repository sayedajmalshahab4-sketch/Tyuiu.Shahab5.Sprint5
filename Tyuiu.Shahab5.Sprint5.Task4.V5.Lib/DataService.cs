using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);

            double y = (4.26 * x) / Math.Sin(x); 
            y = Math.Round(y, 3);

            return y;
        }
    }
}