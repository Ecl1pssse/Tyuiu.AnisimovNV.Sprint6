using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5.Test
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
            // При x = -5: F(-5) = (2*sin(-5))/(3*(-5)+1.2) + cos(-5) - 14*(-5)
            // sin(-5) ? 0.9589, cos(-5) ? 0.2837
            // 2*0.9589 / (-15+1.2) + 0.2837 + 70 = 1.9178 / -13.8 + 70.2837 ? 70.1447 ? 70.14
            Assert.Equal(70.14, result[0], 2);

            // При x = 0: F(0) = (2*sin(0))/(3*0+1.2) + cos(0) - 14*0 = 0 + 1 + 0 = 1
            Assert.Equal(1.00, result[5], 2);
        }
    }
}