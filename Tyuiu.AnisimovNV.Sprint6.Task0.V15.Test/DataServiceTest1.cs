using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task0.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.AnisimovNV.Sprint6.Task0.V15.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 3;

            // Act
            double result = ds.Calculate(x);

            // Assert
            double wait = 64.0; // 27 + 18 + 15 + 4 = 64
            Assert.Equal(wait, result);
        }

        [Fact]
        public void ValidCalculateWithThreeDecimals()
        {
            // Arrange
            DataService ds = new DataService();
            int x = 3;

            // Act
            double result = ds.Calculate(x);

            // Assert
            // Проверяем, что результат округлен до 3 знаков
            string resultString = result.ToString("F3");
            Assert.Equal("64,000", resultString);
        }
    }
}