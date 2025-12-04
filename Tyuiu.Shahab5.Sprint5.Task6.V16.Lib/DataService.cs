using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Shahab5.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public DataService()
        {
        }

        public int LoadFromDataFile(string path)
        {
            // Читаем весь текст из файла
            string strLine = File.ReadAllText(path);

            // Используем регулярное выражение для поиска английских слов
            // Английские слова: только буквы от a до z (регистр неважен)
            Regex regex = new Regex(@"[a-zA-Z]+");
            MatchCollection matches = regex.Matches(strLine);

            // Возвращаем количество найденных слов
            return matches.Count;
        }
    }
}