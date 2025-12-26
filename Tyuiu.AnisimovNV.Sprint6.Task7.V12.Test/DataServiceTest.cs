using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidGetMatrix()
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
            Assert.Equal(1, result[0, 0]);    // не изменяется
            Assert.Equal(10, result[1, 0]);   // не изменяется
        }

        [Fact]
        public void MatrixWithLessColumns()
        {
            DataService ds = new DataService();

            int[,] testMatrix = {
                {1, 2, 3},
                {4, 5, 6}
            };

            int[,] result = ds.GetMatrix(testMatrix);

            // Проверяем, что матрица не изменилась (нет 9-го столбца)
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.Equal(testMatrix[i, j], result[i, j]);
                }
            }
        }
    }
}