using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task2.V26.Lib
{
    public class DataService : ISprint6Task2V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль (хотя в этой формуле нет деления на переменную)
                // Но по условию нужна проверка
                if (Math.Abs(2) < 0.0001) // проверка знаменателя (2) на ноль
                {
                    y = 0;
                }
                else
                {
                    // Вычисление функции: F(x) = sin(x) + cos(2x)/2 - 1.5x
                    y = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;
                }

                // Округление до 2 знаков после запятой
                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}