using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void TestCollectTextFromFile()
        {
            DataService ds = new DataService();

            string testFile = "test.txt";
            File.WriteAllLines(testFile, new string[]
            {
                "один два три четыре пять",
                "раз два три четыре",
                "слово1 слово2 слово3 слово4"
            });

            string result = ds.CollectTextFromFile(testFile);

            Assert.Equal("четыре\r\nтри\r\nслово4", result);

            File.Delete(testFile);
        }
    }
}