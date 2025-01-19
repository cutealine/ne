using System;

namespace _10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputNumber("Введите натуральное число n: ", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Условие n - натуральное число не выполняется");
                Console.ReadKey();
                return;
            }

            double sum = 0;
            for (var i = 1; i <= n; i++)
            {
                sum += (i / (i + 1.0));
            }

            Console.WriteLine($"Сумма от 1/2 до {n}/{n + 1} равна {sum}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                return false;
            }

            return true;
        }
    }
}