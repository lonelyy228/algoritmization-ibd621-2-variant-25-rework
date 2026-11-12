using System;

namespace Task_2_1
{
    /// <summary>
    /// Выбор отрезка, длину которого нужно вычислить.
    /// </summary>
    internal enum Calculation
    {
        /// <summary>Вариант вычисления не выбран.</summary>
        None = 0,

        /// <summary>Вычислить медиану к стороне a.</summary>
        Median = 1,

        /// <summary>Вычислить биссектрису к стороне a.</summary>
        Bisector = 2
    }

    internal static class Program
    {
        /// <summary>
        /// Выбирает расчёт и выводит длину медианы или биссектрисы к стороне a.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            Calculation calculation = GetCalculation();
            if (calculation == Calculation.None)
            {
                Console.WriteLine("Вариант вычисления не выбран.");
                return;
            }

            double a = GetPositiveNumber("Введите сторону a = ");
            double b = GetPositiveNumber("Введите сторону b = ");
            double c = GetPositiveNumber("Введите сторону c = ");

            if (!IsTriangle(a, b, c))
            {
                Console.WriteLine("Треугольника с такими сторонами не существует.");
                return;
            }

            switch (calculation)
            {
                case Calculation.Median:
                    Console.WriteLine($"Медиана к стороне a = {GetMedian(a, b, c)}");
                    break;
                case Calculation.Bisector:
                    Console.WriteLine($"Биссектриса к стороне a = {GetBisector(a, b, c)}");
                    break;
            }
        }

        /// <summary>
        /// Считывает номер выбранного расчёта.
        /// </summary>
        /// <returns>Выбранный вариант расчёта.</returns>
        static Calculation GetCalculation()
        {
            while (true)
            {
                Console.Write($"{(int)Calculation.Median} — медиана, {(int)Calculation.Bisector} — биссектриса: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    return Calculation.None;
                }

                Calculation choice = Calculation.None;
                if (int.TryParse(input, out int number))
                {
                    choice = (Calculation)number;
                }

                if (choice == Calculation.Median || choice == Calculation.Bisector)
                {
                    return choice;
                }

                Console.WriteLine($"Введите {(int)Calculation.Median} или {(int)Calculation.Bisector}.");
            }
        }

        /// <summary>
        /// Считывает положительную длину стороны.
        /// </summary>
        /// <param name="message">Приглашение ко вводу.</param>
        /// <returns>Положительная длина.</returns>
        static double GetPositiveNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()!;
                if (double.TryParse(input, out double value) && value > 0 && double.IsFinite(value))
                {
                    return value;
                }

                Console.WriteLine("Введите положительное число.");
            }
        }

        /// <summary>
        /// Проверяет неравенства треугольника.
        /// </summary>
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        /// <returns>True, если треугольник существует.</returns>
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Вычисляет длину медианы к стороне a.
        /// </summary>
        /// <param name="a">Сторона, к которой проведена медиана.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        /// <returns>Длина медианы.</returns>
        static double GetMedian(double a, double b, double c)
        {
            return Math.Sqrt(2 * b * b + 2 * c * c - a * a) / 2;
        }

        /// <summary>
        /// Вычисляет длину биссектрисы к стороне a.
        /// </summary>
        /// <param name="a">Сторона, к которой проведена биссектриса.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        /// <returns>Длина биссектрисы.</returns>
        static double GetBisector(double a, double b, double c)
        {
            return Math.Sqrt(b * c * ((b + c) * (b + c) - a * a)) / (b + c);
        }
    }
}
