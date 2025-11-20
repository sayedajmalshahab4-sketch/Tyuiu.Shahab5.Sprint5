using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;


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

            // Вычисление значения функции
            double y = 6.0 * Math.Pow(x, 4) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            y = Math.Round(y, 3);

            // Запись в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            // Чтение файла и преобразование в Base64 для проверки
            byte[] fileBytes = File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(fileBytes);

            return base64String;
        }
    }
}