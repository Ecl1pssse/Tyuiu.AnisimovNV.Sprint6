using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib
{
    public class DataService
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            string[] allLines = File.ReadAllLines(path);

            foreach (string line in allLines)
            {
                string[] words = line.Split(' ');

                if (words.Length >= 4)
                {
                    result = result + words[3] + "\r\n";
                }
                else
                {
                    result = result + "\r\n";
                }
            }

            return result.Trim();
        }
    }
}