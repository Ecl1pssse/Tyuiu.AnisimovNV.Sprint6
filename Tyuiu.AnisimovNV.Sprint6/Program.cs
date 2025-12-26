using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.AnisimovNV.Sprint6.Task0.V15.Lib;

namespace Tyuiu.AnisimovNV.Sprint6.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Шапка с данными студента
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"* Значение переменной X = {x}                                             *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем экземпляр DataService и вычисляем результат
            DataService ds = new DataService();
            double result = ds.Calculate(x);

            // Выводим результат с 3 знаками после запятой
            Console.WriteLine($"* Значение функции F(x) = x^3 + 2x^2 + 5x + 4 при x = {x} равно {result:F3}      *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫВОД:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Для Windows Forms приложения результат будет: {result:F3}                    *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}