using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки файла
            string[] allLines = File.ReadAllLines(path);

            // Фильтруем пустые строки и строки только с пробелами
            var lines = new System.Collections.Generic.List<string>();
            foreach (string line in allLines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line.Trim());
                }
            }

            if (lines.Count == 0)
            {
                throw new Exception("Файл пуст или содержит только пустые строки");
            }

            // Определяем количество столбцов по первой непустой строке
            int rows = lines.Count;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                // Проверяем, что количество столбцов совпадает
                if (values.Length != columns)
                {
                    throw new Exception($"Несоответствие количества столбцов в строке {i + 1}. Ожидалось: {columns}, получено: {values.Length}");
                }

                for (int j = 0; j < columns; j++)
                {
                    // Убираем пробелы и пытаемся преобразовать в число
                    string trimmedValue = values[j].Trim();
                    if (string.IsNullOrEmpty(trimmedValue))
                    {
                        throw new Exception($"Пустое значение в строке {i + 1}, столбец {j + 1}");
                    }

                    if (!int.TryParse(trimmedValue, out int parsedValue))
                    {
                        throw new Exception($"Неверный формат числа в строке {i + 1}, столбец {j + 1}: '{values[j]}'");
                    }

                    matrix[i, j] = parsedValue;
                }
            }

            return matrix;
        }

        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем копию матрицы
            int[,] resultMatrix = new int[rows, columns];

            // Копируем все значения
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = matrix[i, j];
                }
            }

            // Модифицируем 9-й столбец (индекс 8)
            int targetColumn = 8;

            // Проверяем, что столбец существует
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