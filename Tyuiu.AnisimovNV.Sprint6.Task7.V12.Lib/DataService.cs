using System;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib
{
    public class DataService
    {
        public int[,] LoadFromFileData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }

            return matrix;
        }

        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            // Копируем исходную матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = matrix[i, j];
                }
            }

            // Модифицируем 9-й столбец (индекс 8)
            int targetColumn = 8;

            if (columns > targetColumn)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (resultMatrix[i, targetColumn] != 10)
                    {
                        resultMatrix[i, targetColumn] = 0;
                    }
                }
            }

            return resultMatrix;
        }
    }
}