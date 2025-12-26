using System;
using Tyuiu.AnisimovNV.Sprint6.Task7.V12.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task7.V12
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #6 | Выполнил: Анисимов Н.В. | ИСТИБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #6                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Анисимов Н.В. | ИСТИБ-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = x^3 + 2x^2 + 5x + 4, вычислить его значение      *");
            Console.WriteLine("* при x = 3, результат вывести в TextBox. Округлить до трёх знаков.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"F({x}) = {result:F3}");

            Console.ReadKey();
        }
    }
}