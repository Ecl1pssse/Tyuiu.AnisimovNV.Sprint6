using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию массива
            int[,] result = new int[rows, cols];
            Array.Copy(matrix, result, matrix.Length);

            // Сортировка строк по 4-му столбцу (индекс 3)
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в 4-м столбце (индекс 3)
                    if (result[j, 3] > result[j + 1, 3])
                    {
                        // Меняем строки местами
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = result[j, k];
                            result[j, k] = result[j + 1, k];
                            result[j + 1, k] = temp;
                        }
                    }
                }
            }

            return result;
        }

        public int[,] GetMatrix()
        {
            // Исходная матрица 5x5 из условия
            int[,] matrix = new int[5, 5]
            {
                { 31,  25, -18,  12,   9 },
                {  6,  34,  -2,   2, -18 },
                { -5,   4,  27,   4,  -1 },
                {  4,  15,  34,  -6, -10 },
                {  0,   8,   5,  14, -17 }
            };

            return matrix;
        }
    }
}