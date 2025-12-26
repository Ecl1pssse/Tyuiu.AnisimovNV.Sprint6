using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                if (words.Length > 3)
                    result += words[3] + "\r\n";
                else
                    result += "\r\n";
            }

            return result.Trim();
        }
    }
}