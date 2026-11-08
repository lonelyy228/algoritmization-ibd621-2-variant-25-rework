using System;

namespace Task_2_3
{
    internal static class Program
    {
        /// <summary>
        /// Вводит границы двух отрезков и выводит их пересечение.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            double a = GetNumber("Введите a = ");
            double b = GetNumber("Введите b = ");
            double c = GetNumber("Введите c = ");
            double d = GetNumber("Введите d = ");

            Console.WriteLine(DescribeIntersection(a, b, c, d));
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

        /// <summary>
        /// Находит общую часть отрезков [a, b] и [c, d].
        /// </summary>
        /// <param name="a">Левая граница первого отрезка.</param>
        /// <param name="b">Правая граница первого отрезка.</param>
        /// <param name="c">Левая граница второго отрезка.</param>
        /// <param name="d">Правая граница второго отрезка.</param>
        /// <returns>Описание пересечения или сообщение об ошибке границ.</returns>
        static string DescribeIntersection(double a, double b, double c, double d)
        {
            if (a > b || c > d)
            {
                return "Границы отрезков заданы неверно: должно быть a ≤ b и c ≤ d.";
            }

            double left = Math.Max(a, c);
            double right = Math.Min(b, d);

            if (left > right)
            {
                return "Пересечения нет.";
            }

            if (left == right)
            {
                return $"Пересечение — точка {left}.";
            }

            return $"Пересечение — отрезок [{left}; {right}].";
        }
    }
}
