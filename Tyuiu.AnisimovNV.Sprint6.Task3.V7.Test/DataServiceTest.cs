using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task3.V7.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task3.V7.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Получаем исходную матрицу
            int[,] matrix = ds.GetMatrix();

            // Сортируем
            int[,] result = ds.Calculate(matrix);

            // Проверяем размеры
            Assert.Equal(5, result.GetLength(0));
            Assert.Equal(5, result.GetLength(1));

            // Проверяем, что 4-й столбец отсортирован по возрастанию
            // Исходные значения 4-го столбца: 12, 2, 4, -6, 14
            // После сортировки должно быть: -6, 2, 4, 12, 14

            int[] sortedFourthColumn = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sortedFourthColumn[i] = result[i, 3];
            }

            // Проверяем сортировку
            Assert.Equal(-6, sortedFourthColumn[0]);
            Assert.Equal(2, sortedFourthColumn[1]);
            Assert.Equal(4, sortedFourthColumn[2]);
            Assert.Equal(12, sortedFourthColumn[3]);
            Assert.Equal(14, sortedFourthColumn[4]);

            // Проверяем, что строки переместились целиком
            // Первая строка (самая маленькая в 4-м столбце = -6) должна быть из 4-й строки исходной
            Assert.Equal(4, result[0, 0]);   // Была 4 строка: {4, 15, 34, -6, -10}
            Assert.Equal(15, result[0, 1]);
            Assert.Equal(34, result[0, 2]);
            Assert.Equal(-6, result[0, 3]);
            Assert.Equal(-10, result[0, 4]);

            // Последняя строка (самая большая в 4-м столбце = 14) должна быть из 5-й строки исходной
            Assert.Equal(0, result[4, 0]);   // Была 5 строка: {0, 8, 5, 14, -17}
            Assert.Equal(8, result[4, 1]);
            Assert.Equal(5, result[4, 2]);
            Assert.Equal(14, result[4, 3]);
            Assert.Equal(-17, result[4, 4]);
        }

        [Fact]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetMatrix();

            // Проверяем размеры
            Assert.Equal(5, matrix.GetLength(0));
            Assert.Equal(5, matrix.GetLength(1));

            // Проверяем несколько значений
            Assert.Equal(31, matrix[0, 0]);
            Assert.Equal(-18, matrix[0, 4]);
            Assert.Equal(-5, matrix[2, 0]);
            Assert.Equal(-17, matrix[4, 4]);

            // Проверяем 4-й столбец (индекс 3)
            Assert.Equal(12, matrix[0, 3]);
            Assert.Equal(2, matrix[1, 3]);
            Assert.Equal(4, matrix[2, 3]);
            Assert.Equal(-6, matrix[3, 3]);
            Assert.Equal(14, matrix[4, 3]);
        }
    }
}