using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task1.V27.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task1.V27.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.Equal(11, result.Length);
            Assert.Equal(0, result[6]); // x = 1 (деление на ноль)

            // ѕровер€ем несколько значений
            Assert.Equal(13.81, result[0]); // x = -5
            Assert.Equal(-5.71, result[10]); // x = 5
        }
    }
}