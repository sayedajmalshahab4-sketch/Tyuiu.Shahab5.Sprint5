using System;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task1.V24.Lib
{
    public class DataService
    {
        public string SaveToFileBinaryData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисление значения функции (пример формулы)
            double y = Math.Pow(x, 2) + Math.Sin(x) + 2.5 * x - 1.5;
            y = Math.Round(y, 3);

            // Запись результата в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
