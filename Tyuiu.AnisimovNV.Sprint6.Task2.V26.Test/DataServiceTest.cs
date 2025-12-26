using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task2.V26.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task2.V26.Test
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

            // Проверяем несколько значений
            // При x = -5: sin(-5) + cos(-10)/2 - 1.5*(-5) = sin(-5) + cos(-10)/2 + 7.5
            // sin(-5) ? 0.9589, cos(-10) ? -0.8391
            // 0.9589 + (-0.8391)/2 + 7.5 = 0.9589 - 0.4196 + 7.5 ? 8.0393 ? 8.04
            Assert.Equal(8.04, result[0], 2);

            // При x = 0: sin(0) + cos(0)/2 - 1.5*0 = 0 + 1/2 - 0 = 0.5 ? 0.5
            Assert.Equal(0.5, result[5], 2);

            // При x = 5: sin(5) + cos(10)/2 - 1.5*5 = sin(5) + cos(10)/2 - 7.5
            // sin(5) ? -0.9589, cos(10) ? -0.8391
            // -0.9589 + (-0.8391)/2 - 7.5 = -0.9589 - 0.4196 - 7.5 ? -8.8785 ? -8.88
            Assert.Equal(-8.88, result[10], 2);
        }

        [Fact]
        public void CheckRounding()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Проверяем, что округление до 2 знаков работает
            string strValue = result[0].ToString("F2");
            double roundedValue = double.Parse(strValue);
            Assert.Equal(roundedValue, result[0]);
        }
    }
}