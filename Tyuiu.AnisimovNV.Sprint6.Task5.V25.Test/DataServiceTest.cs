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
            string testFilePath = "testInputFile.txt";
            string[] testData = { "1.5", "0", "2.7", "0.0", "-3.2", "4.123456", "0", "-0.001" };
            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();

            // Вызываем метод
            double[] result = ds.LoadFromDataFile(testFilePath);

            // Ожидаемые результаты:
            // 0 и 0.0 отфильтровываются
            // -0.001 также отфильтровывается (близко к 0)
            // 4.123456 округляется до 4.123
            // Остальные: 1.5, 2.7, -3.2, 4.123
            Assert.Equal(4, result.Length);

            // Проверяем значения
            Assert.Equal(1.5, result[0], 3);
            Assert.Equal(2.7, result[1], 3);
            Assert.Equal(-3.2, result[2], 3);
            Assert.Equal(4.123, result[3], 3);

            // Проверяем, что нули отфильтрованы
            foreach (double value in result)
            {
                Assert.NotEqual(0, value);
            }

            // Проверяем округление до 3 знаков
            Assert.Equal(4.123, result[3]); // Было 4.123456, должно стать 4.123

            // Удаляем тестовый файл
            File.Delete(testFilePath);
        }

        [Fact]
        public void CheckFileNotFound()
        {
            DataService ds = new DataService();

            // Пытаемся загрузить несуществующий файл
            Assert.Throws<FileNotFoundException>(() => ds.LoadFromDataFile("nonexistent.txt"));
        }

        [Fact]
        public void CheckEmptyFile()
        {
            // Создаем пустой файл
            string testFilePath = "emptyFile.txt";
            File.WriteAllText(testFilePath, "");

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testFilePath);

            Assert.Empty(result);

            File.Delete(testFilePath);
        }
    }
}