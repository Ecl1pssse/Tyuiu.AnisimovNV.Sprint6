using Xunit;

namespace Tyuiu.AnisimovNV.Sprint7.Task7.V12.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void TestModifyMatrix()
        {
            var ds = new Tyuiu.AnisimovNV.Sprint7.Task7.V12.Lib.DataService();

            int[,] matrix = {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            };

            int[,] result = ds.ModifyMatrix(matrix);

            Assert.Equal(0, result[0, 8]); // 9 ? 0
            Assert.Equal(0, result[1, 8]); // 2 ? 0
            Assert.Equal(1, result[0, 0]); // без изменений
            Assert.Equal(10, result[1, 0]); // без изменений
        }
    }
}