using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidLoadFromDataFile()
        {
            // Создаем тестовый файл
            string testFile = "test.txt";
            File.WriteAllLines(testFile, new string[] { "1.5", "0", "2.7", "0.0", "-3.2" });

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testFile);

            // Ожидаем: [1.5, 2.7, -3.2] (нули отфильтрованы)
            Assert.Equal(3, result.Length);
            Assert.Equal(1.5, result[0], 3);
            Assert.Equal(2.7, result[1], 3);
            Assert.Equal(-3.2, result[2], 3);

            // Удаляем тестовый файл
            File.Delete(testFile);
        }
    }
}
