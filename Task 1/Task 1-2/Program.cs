using System;

namespace Task_1_2
{
    internal static class Program
    {
        /// <summary>
        /// Вводит два числа и выводит сумму их квадратов и квадрат их суммы.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            double a = GetNumber("Введите a = ");
            double b = GetNumber("Введите b = ");

            double sumOfSquares = GetSumOfSquares(a, b);
            double squareOfSum = GetSquareOfSum(a, b);

            Console.WriteLine($"a² + b² = {sumOfSquares}");
            Console.WriteLine($"(a + b)² = {squareOfSum}");
        }

        /// <summary>
        /// Считывает вещественное число с клавиатуры.
        /// </summary>
        /// <param name="message">Приглашение ко вводу числа.</param>
        /// <returns>Введённое число.</returns>
        static double GetNumber(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine()!);
        }

        /// <summary>
        /// Вычисляет сумму квадратов двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Сумма квадратов.</returns>
        static double GetSumOfSquares(double a, double b)
        {
            return a * a + b * b;
        }

        /// <summary>
        /// Вычисляет квадрат суммы двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Квадрат суммы.</returns>
        static double GetSquareOfSum(double a, double b)
        {
            return (a + b) * (a + b);
        }
    }
}
