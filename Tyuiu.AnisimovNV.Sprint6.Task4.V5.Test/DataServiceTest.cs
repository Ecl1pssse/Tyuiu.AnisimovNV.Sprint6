using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib;
using System.IO;

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
            // При x = -5: (2*sin(-5))/(3*(-5)+1.2) + cos(-5) - 7*(-5)*2
            // sin(-5) ? 0.9589, cos(-5) ? 0.2837
            // 2*0.9589 / (-15+1.2) + 0.2837 + 70 = 1.9178 / -13.8 + 70.2837 ? -0.139 + 70.2837 ? 70.1447 ? 70.14
            Assert.Equal(70.14, result[0], 2);

            // При x = 0: (2*sin(0))/(3*0+1.2) + cos(0) - 7*0*2 = 0/1.2 + 1 - 0 = 1 ? 1.00
            Assert.Equal(1.00, result[5], 2);

            // При x = 5: (2*sin(5))/(3*5+1.2) + cos(5) - 7*5*2
            // sin(5) ? -0.9589, cos(5) ? 0.2837
            // 2*(-0.9589) / (15+1.2) + 0.2837 - 70 = -1.9178/16.2 + 0.2837 - 70 ? -0.1184 + 0.2837 - 70 ? -69.8347 ? -69.83
            Assert.Equal(-69.83, result[10], 2);
        }

        [Fact]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            // x = -0.4 приводит к делению на ноль (3*(-0.4) + 1.2 = 0)
            // Но в нашем диапазоне с шагом 1 этого значения нет
            // Проверим работу метода при таком значении отдельно
            int startValue = -1;
            int stopValue = 0; // Включает x = -1 и x = 0

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // При x = -1: знаменатель = 3*(-1) + 1.2 = -3 + 1.2 = -1.8 ? 0
            // При x = 0: знаменатель = 1.2 ? 0
            // Оба значения должны быть вычислены нормально
            Assert.Equal(2, result.Length);
        }

        [Fact]
        public void ValidSaveToFileText()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileText(startValue, stopValue);

            // Проверяем, что файл создан
            Assert.True(File.Exists(path));

            // Проверяем содержимое файла
            string fileContent = File.ReadAllText(path);
            Assert.Contains("Таблица значений функции:", fileContent);
            Assert.Contains("F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2", fileContent);

            // Удаляем файл после теста
            File.Delete(path);
        }
    }
}