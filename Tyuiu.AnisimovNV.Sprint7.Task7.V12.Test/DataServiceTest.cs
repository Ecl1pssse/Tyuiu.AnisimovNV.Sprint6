using System;
using Xunit;
using Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidModifyMatrix()
        {
            DataService ds = new DataService();

            // Тестовая матрица 3x10 (минимально, чтобы был 9-й столбец)
            int[,] testMatrix = new int[3, 10]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 },
                { 5, 5, 5, 5, 5, 5, 5, 5, 10, 5 }
            };

            int[,] result = ds.ModifyMatrix(testMatrix);

            // Проверяем 9-й столбец (индекс 8)
            Assert.Equal(0, result[0, 8]);   // 9 ? 0
            Assert.Equal(0, result[1, 8]);   // 2 ? 0
            Assert.Equal(10, result[2, 8]);  // 10 остается 10

            // Проверяем, что остальные столбцы не изменились
            Assert.Equal(1, result[0, 0]);
            Assert.Equal(5, result[2, 4]);
        }

        [Fact]
        public void ValidSaveMatrixToFile()
        {
            DataService ds = new DataService();

            int[,] testMatrix = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            string testPath = "test_output.csv";

            try
            {
                ds.SaveMatrixToFile(testMatrix, testPath);
                Assert.True(System.IO.File.Exists(testPath));
            }
            finally
            {
                // Очистка тестового файла
                if (System.IO.File.Exists(testPath))
                {
                    System.IO.File.Delete(testPath);
                }
            }
        }

        [Fact]
        public void MatrixWithLessThan9Columns()
        {
            DataService ds = new DataService();

            // Матрица с 5 столбцами (меньше 9)
            int[,] testMatrix = new int[2, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 }
            };

            int[,] result = ds.ModifyMatrix(testMatrix);

            // Проверяем, что матрица не изменилась (т.к. нет 9-го столбца)
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.Equal(testMatrix[i, j], result[i, j]);
                }
            }
        }
    }
}