using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task0.V15.Lib
{
    public class DataService : ISprint6Task0V15
    {
        public double Calculate(int x)
        {
            // Вычисляем значение функции: x^3 + 2x^2 + 5x + 4
            double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}