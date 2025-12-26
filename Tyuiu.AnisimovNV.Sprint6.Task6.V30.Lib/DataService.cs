using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Разделяем строку на слова (пробелы, табуляции)
                string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Если в строке есть хотя бы 4 слова
                if (words.Length >= 4)
                {
                    // Берем четвертое слово (индекс 3)
                    result += words[3] + Environment.NewLine;
                }
                else
                {
                    // Если меньше 4 слов, добавляем пустую строку
                    result += Environment.NewLine;
                }
            }

            return result.TrimEnd(); // Убираем последний перевод строки
        }
    }
}