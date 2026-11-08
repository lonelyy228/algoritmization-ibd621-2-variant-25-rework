using System;

namespace Task_2_2
{
    internal static class Program
    {
        /// <summary>
        /// Меняет числа местами при a больше b и выводит результат.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            double a = GetNumber("Введите a = ");
            double b = GetNumber("Введите b = ");
            Console.WriteLine($"Исходные значения: a = {a}; b = {b}");

            SwapIfNeeded(ref a, ref b);

            Console.WriteLine($"Новые значения: a = {a}; b = {b}");
        }

        /// <summary>
        /// Меняет два числа местами, если первое больше второго.
        /// </summary>
        /// <param name="a">Первое число; после вызова не больше второго.</param>
        /// <param name="b">Второе число; после вызова не меньше первого.</param>
        static void SwapIfNeeded(ref double a, ref double b)
        {
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
        }

        /// <summary>
        /// Считывает вещественное число с проверкой ввода.
        /// </summary>
        /// <param name="message">Приглашение ко вводу.</param>
        /// <returns>Введённое число.</returns>
        static double GetNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()!;
                if (double.TryParse(input, out double value) && double.IsFinite(value))
                {
                    return value;
                }

                Console.WriteLine("Введите число.");
            }
        }
    }
}
