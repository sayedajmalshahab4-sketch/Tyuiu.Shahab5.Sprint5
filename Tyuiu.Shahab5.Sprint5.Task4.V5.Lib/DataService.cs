using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Shahab5.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public DataService()
        {
        }

        public double LoadFromDataFile(string path)
        {
            // Читаем значение из файла
            string strX = File.ReadAllText(path);

            // Заменяем точку на запятую для корректного парсинга
            strX = strX.Replace('.', ',');

            // Парсим значение x
            double x = Convert.ToDouble(strX);

            // Вычисляем значение по формуле: y = (4.26 * x) / sin(x)
            double y = (4.26 * x) / Math.Sin(x);

            // Округляем до трёх знаков после запятой
            y = Math.Round(y, 3);

            return y;
        }
    }
}