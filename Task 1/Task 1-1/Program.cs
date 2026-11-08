using System;

namespace Task_1_1
{
    internal static class Program
    {
        /// <summary>
        /// Считывает x, вычисляет и выводит значение функции.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 1;
            const double c = 3;

            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }

        /// <summary>
        /// Считывает вещественное число с клавиатуры.
        /// </summary>
        /// <param name="message">Приглашение ко вводу числа.</param>
        /// <returns>Введённое число.</returns>
        static double GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine()!;
            return double.Parse(input);
        }

        /// <summary>
        /// Вычисляет значение функции варианта 25.
        /// </summary>
        /// <param name="a">Константа a.</param>
        /// <param name="b">Константа b.</param>
        /// <param name="c">Константа c.</param>
        /// <param name="x">Введённое значение x.</param>
        /// <returns>Вычисленное значение y.</returns>
        static double GetResult(double a, double b, double c, double x)
        {
            return ((3.0 / 4.0) * a *
                Math.Sqrt(x * x + b * Math.Abs(x)) + c) /
                (x * x + Math.Sin(x));
        }
    }
}