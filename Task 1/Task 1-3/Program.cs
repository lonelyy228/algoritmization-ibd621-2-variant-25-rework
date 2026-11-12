using System;

namespace Task_1_3
{
    internal static class Program
    {
        /// <summary>
        /// Вводит сопротивление, время и напряжение, затем выводит заряд.
        /// </summary>
        /// <param name="args">Аргументы командной строки; не используются.</param>
        static void Main(string[] args)
        {
            double resistance = GetNumber("Введите сопротивление R (Ом) = ");
            double time = GetNumber("Введите время t (с) = ");
            double voltage = GetNumber("Введите напряжение U (В) = ");

            double charge = GetCharge(resistance, time, voltage);
            Console.WriteLine($"R = {resistance} Ом; t = {time} с; U = {voltage} В");
            Console.WriteLine($"Заряд q = {charge} Кл");
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
        /// Вычисляет заряд по закону Ома: q = U · t / R.
        /// </summary>
        /// <param name="resistance">Сопротивление R в омах.</param>
        /// <param name="time">Время t в секундах.</param>
        /// <param name="voltage">Напряжение U в вольтах.</param>
        /// <returns>Заряд q в кулонах.</returns>
        static double GetCharge(double resistance, double time, double voltage)
        {
            return voltage * time / resistance;
        }
    }
}
