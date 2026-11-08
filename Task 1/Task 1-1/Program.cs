using System;

namespace Task_1_1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 1;
            const double c = 3;

            Console.Write("Введите x = ");
            string input = Console.ReadLine()!;
            double x = double.Parse(input);

            double y = ((3.0 / 4.0) * a *
                Math.Sqrt(x * x + b * Math.Abs(x)) + c) /
                (x * x + Math.Sin(x));

            Console.WriteLine($"x = {x}; y = {y}");
        }
    }
}