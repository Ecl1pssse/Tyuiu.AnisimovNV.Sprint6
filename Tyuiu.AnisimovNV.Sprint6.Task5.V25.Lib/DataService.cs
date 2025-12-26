using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public double[] LoadFromDataFile(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Преобразуем строки в числа, фильтруем ненулевые и округляем
            var result = lines
                .Select(line => double.TryParse(line, out double value) ? value : 0)
                .Where(value => Math.Abs(value) > 0.001) // Исключаем нули (с учетом погрешности)
                .Select(value => Math.Round(value, 3))   // Округляем до 3 знаков
                .ToArray();

            return result;
        }
    }
}