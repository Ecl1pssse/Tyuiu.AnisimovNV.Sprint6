using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: 3*x + 1.2 = 0
                if (Math.Abs(3 * x + 1.2) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    // Вычисление функции: F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                }

                // Округление до 2 знаков после запятой
                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }

        public string SaveToFileText(int startValue, int stopValue)
        {
            string path = @"OutPutFileTask4V5.txt";

            double[] values = GetMassFunction(startValue, stopValue);

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine("Таблица значений функции:");
                writer.WriteLine("F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}], шаг: 1");
                writer.WriteLine();
                writer.WriteLine("+----------+----------+");
                writer.WriteLine("|    X     |   F(x)   |");
                writer.WriteLine("+----------+----------+");

                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    writer.WriteLine($"|{x,5}     | {values[count],7:F2}  |");
                    count++;
                }

                writer.WriteLine("+----------+----------+");
            }

            return Path.GetFullPath(path);
        }
    }
}