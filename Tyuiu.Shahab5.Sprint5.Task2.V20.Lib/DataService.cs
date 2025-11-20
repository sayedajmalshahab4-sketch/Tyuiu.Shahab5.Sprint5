using System;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.Shahab5.Sprint5.Task2.V20.Lib
{
    public class DataService : ISprint5Task2V20
    {
        public DataService()
        {
        }

        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            // Обработка массива: положительные -> 1, отрицательные -> 0
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        // Замена положительных на 1, отрицательных на 0
                        int value = matrix[i, j] > 0 ? 1 : 0;
                        writer.Write(value);

                        // Добавление разделителя, кроме последнего элемента в строке
                        if (j < columns - 1)
                        {
                            writer.Write(";");
                        }
                    }
                    writer.WriteLine();
                }
            }

            return path;
        }
    }
}