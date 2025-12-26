using System;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        public int[,] ModifyMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 8 && matrix[i, j] != 10)
                    {
                        result[i, j] = 0;
                    }
                    else
                    {
                        result[i, j] = matrix[i, j];
                    }
                }
            }

            return result;
        }

        public void SaveMatrixToFile(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] values = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    values[j] = matrix[i, j].ToString();
                }
                lines[i] = string.Join(";", values);
            }

            File.WriteAllLines(path, lines);
        }
    }
}