using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidCollectTextFromFile()
        {
            // Создаем тестовый файл
            string testFilePath = "testFile.txt";
            string[] testData =
            {
                "один два три четыре пять шесть",
                "word1 word2 word3 word4 word5",
                "а б в г д е",
                "строка с тремя словами",
                "1 2 3 4 5 6 7"
            };

            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testFilePath);

            // Ожидаемый результат: четвертые слова из каждой строки
            // 1. "четыре"
            // 2. "word4"
            // 3. "г"
            // 4. (пусто - в строке только 3 слова)
            // 5. "4"
            string expected = "четыре\r\nword4\r\nг\r\n\r\n4";

            Assert.Equal(expected, result);

            // Удаляем тестовый файл
            File.Delete(testFilePath);
        }

        [Fact]
        public void CheckEmptyFile()
        {
            // Создаем пустой файл
            string testFilePath = "emptyFile.txt";
            File.WriteAllText(testFilePath, "");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testFilePath);

            Assert.Equal("", result);

            File.Delete(testFilePath);
        }

        [Fact]
        public void CheckFileWithNoFourthWords()
        {
            // Создаем файл без четвертых слов
            string testFilePath = "noFourth.txt";
            string[] testData =
            {
                "один два три",
                "слово1 слово2",
                "a b",
                "только одно слово"
            };

            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testFilePath);

            // Все строки должны быть пустыми
            Assert.Equal("\r\n\r\n\r\n", result);

            File.Delete(testFilePath);
        }
    }
}