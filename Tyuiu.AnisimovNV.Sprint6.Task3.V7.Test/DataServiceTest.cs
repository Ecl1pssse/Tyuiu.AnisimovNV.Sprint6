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
            Assert.Equal(-6, result[0, 3]);  // Первая строка, 4-й столбец
            Assert.Equal(2, result[1, 3]);  // Вторая строка, 4-й столбец
            Assert.Equal(4, result[2, 3]);  // Третья строка, 4-й столбец
            Assert.Equal(12, result[3, 3]);  // Четвертая строка, 4-й столбец
            Assert.Equal(14, result[4, 3]);  // Пятая строка, 4-й столбец

            // Проверяем, что остальные элементы не изменились
            // Первая строка
            Assert.Equal(31, result[0, 0]);
            Assert.Equal(25, result[0, 1]);
            Assert.Equal(-18, result[0, 2]);
            Assert.Equal(9, result[0, 4]);

            // Вторая строка
            Assert.Equal(6, result[1, 0]);
            Assert.Equal(34, result[1, 1]);
            Assert.Equal(-2, result[1, 2]);
            Assert.Equal(-18, result[1, 4]);

            // Третья строка
            Assert.Equal(-5, result[2, 0]);
            Assert.Equal(4, result[2, 1]);
            Assert.Equal(27, result[2, 2]);
            Assert.Equal(-1, result[2, 4]);

            // Четвертая строка
            Assert.Equal(4, result[3, 0]);
            Assert.Equal(15, result[3, 1]);
            Assert.Equal(34, result[3, 2]);
            Assert.Equal(-10, result[3, 4]);

            // Пятая строка
            Assert.Equal(0, result[4, 0]);
            Assert.Equal(8, result[4, 1]);
            Assert.Equal(5, result[4, 2]);
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
            Assert.Equal(12, matrix[0, 3]);  // 4-й столбец исходный
            Assert.Equal(-6, matrix[3, 3]);  // 4-й столбец исходный
        }
    }
}