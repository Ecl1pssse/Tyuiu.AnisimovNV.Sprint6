using System;
using System.IO;

// Внимание! Убедитесь, что установлен пакет Tyuiu.Courses.Programming.Interfaces
// Если его нет, используйте этот код:

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib
{
    public class DataService // Уберите : ISprint7Task7V12 если нет интерфейса
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        public int[,] ModifyMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] resultMatrix = (int[,])matrix.Clone();

            int targetColumn = 8; // 9-й столбец

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

        public void SaveMatrixToFile(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        writer.Write(matrix[i, j]);
                        if (j < columns - 1)
                        {
                            writer.Write(";");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}