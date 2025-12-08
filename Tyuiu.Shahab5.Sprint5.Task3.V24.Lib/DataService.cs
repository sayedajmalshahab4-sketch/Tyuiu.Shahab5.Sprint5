using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Shahab5.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public DataService()
        {
        }

        public string SaveToFileBinaryData(int x)
        {
            // ВАЖНО: Используем формулу F(x) = 6.1x^3 + 0.23x^2 + 1.04x
            // а не 67x^3 как было в другом задании!
            double y = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;

            // Округляем до трёх знаков после запятой
            y = Math.Round(y, 3);

            // Создаем путь к файлу в папке Temp
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Записываем значение в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }

        public string SaveToFileTextData(int x)
        {
            throw new NotImplementedException();
        }
    }
}