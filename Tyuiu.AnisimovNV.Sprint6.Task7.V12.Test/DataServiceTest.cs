using System;
using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidGetMatrixFromArray()
        {
            DataService ds = new DataService();

            int[,] testMatrix = {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {10, 9, 8, 7, 6, 5, 4, 3, 2, 1},
                {5, 5, 5, 5, 5, 5, 5, 5, 10, 5}
            };

            int[,] result = ds.GetMatrix(testMatrix);

            Assert.Equal(0, result[0, 8]);    // 9 ? 0
            Assert.Equal(0, result[1, 8]);    // 2 ? 0
            Assert.Equal(10, result[2, 8]);   // 10 остается 10

            // Проверяем, что остальные столбцы не изменились
            Assert.Equal(1, result[0, 0]);
            Assert.Equal(10, result[1, 0]);
            Assert.Equal(5, result[2, 0]);
        }

        [Fact]
        public void MatrixWithLessThan9Columns()
        {
            DataService ds = new DataService();

            int[,] testMatrix = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10}
            };

            int[,] result = ds.GetMatrix(testMatrix);

            // Матрица не должна измениться, так как нет 9-го столбца
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.Equal(testMatrix[i, j], result[i, j]);
                }
            }
        }

        [Fact]
        public void TestEmptyStringHandling()
        {
            DataService ds = new DataService();

            // Создаем временный файл с пустыми строками
            string tempFile = Path.GetTempFileName();

            try
            {
                // Записываем данные с пустыми строками
                File.WriteAllText(tempFile, "1;2;3;4;5;6;7;8;9;10\n\n10;9;8;7;6;5;4;3;2;1");

                // Должен выбросить исключение, так как есть пустая строка
                Assert.Throws<Exception>(() => ds.GetMatrix(tempFile));
            }
            finally
            {
                if (File.Exists(tempFile))
                {
                    File.Delete(tempFile);
                }
            }
        }
    }
}