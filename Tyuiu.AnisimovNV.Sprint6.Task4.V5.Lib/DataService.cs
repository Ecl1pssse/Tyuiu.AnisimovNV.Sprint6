using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AnisimovNV.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль
                if (Math.Abs(3 * x + 1.2) < 0.001) // если знаменатель близок к 0
                {
                    y = 0;
                }
                else
                {
                    // F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 14 * x;
                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}