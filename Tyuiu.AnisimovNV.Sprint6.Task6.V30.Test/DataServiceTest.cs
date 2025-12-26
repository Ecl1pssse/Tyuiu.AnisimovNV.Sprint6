using Xunit;
using Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib;
using System.IO;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void TestMethod1()
        {
            string testFile = "test.txt";
            File.WriteAllText(testFile, "один два три четыре\nпять шесть семь восемь");

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(testFile);

            Assert.Equal("четыре\r\nвосемь", result);

            File.Delete(testFile);
        }
    }
}