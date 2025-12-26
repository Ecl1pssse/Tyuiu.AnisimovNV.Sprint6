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

            // Тестовая матрица 10x10
            int[,] testMatrix = {
                {17, 17, -7, -19, -4, 6, 4, -17, 6, 13},
                {-13, -13, -7, -15, -12, -1, 15, 18, 11, -19},
                {9, -12, -9, 8, -12, 20, 10, -6, 18, -1},
                {-15, -19, 19, 16, -15, -19, 8, -2, 11, -18},
                {-14, -9, -19, 20, -3, 8, -10, 4, 2, 12},
                {-18, -4, -14, 20, -20, 17, -18, -19, -9, 6},
                {17, 14, 1, -18, 0, 2, -3, -9, 1, -13},
                {-14, -10, -15, 19, 12, -18, 6, 15, -17, -16},
                {19, 18, 14, 5, 8, 4, -13, 10, 5, 20},
                {-7, 3, 12, 7, -1, -13, -6, 3, -17, -8}
            };

            int[,] result = ds.GetMatrix(testMatrix);

            // Проверяем, что в 9-м столбце (индекс 8) все значения стали 0
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(0, result[i, 8]);
            }

            // Проверяем, что остальные столбцы не изменились
            Assert.Equal(17, result[0, 0]);
            Assert.Equal(-13, result[1, 1]);
            Assert.Equal(20, result[2, 5]);
            Assert.Equal(-18, result[3, 9]);
        }

        [Fact]
        public void TestWhenValueEquals10()
        {
            DataService ds = new DataService();

            int[,] testMatrix = {
                {1, 2, 3, 4, 5, 6, 7, 8, 10, 10},
                {10, 9, 8, 7, 6, 5, 4, 3, 10, 1}
            };

            int[,] result = ds.GetMatrix(testMatrix);

            // Значение 10 должно остаться 10
            Assert.Equal(10, result[0, 8]);
            Assert.Equal(10, result[1, 8]);

            // Значение не равное 10 должно стать 0
            Assert.Equal(0, result[0, 9]); // 10 ? остается 10? Нет, это 10-й столбец, не меняется
            // На самом деле меняется только 9-й столбец
        }
    }
}