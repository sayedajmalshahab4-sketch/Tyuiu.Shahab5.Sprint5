using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.Shahab5.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public DataService()
        {
        }

        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисление значения функции F(x) = 6x⁴ + 0.23x² + 1.04x
            double y = 6.0 * Math.Pow(x, 4) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            y = Math.Round(y, 3);

            // Запись в бинарный файл с использованием MemoryStream
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8, false))
            {
                // Записываем double в бинарном формате
                writer.Write(y);
            }

            return path;
        }
    }
}