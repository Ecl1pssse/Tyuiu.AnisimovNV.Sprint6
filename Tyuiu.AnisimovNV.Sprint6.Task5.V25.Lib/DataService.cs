using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> result = new List<double>();

            // Читаем файл
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Пытаемся преобразовать в число
                if (double.TryParse(line.Replace('.', ','), out double value))
                {
                    // Фильтруем ненулевые значения и округляем до 3 знаков
                    if (Math.Abs(value) > 0.001)
                    {
                        result.Add(Math.Round(value, 3));
                    }
                }
            }

            return result.ToArray();
        }
    }
}