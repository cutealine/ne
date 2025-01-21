using System;

namespace _10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputNumber("Введите число n (количество цифр):", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Число n должно быть натуральным.");
                Console.ReadKey();
                return;
            }

            int k = 0;
            if (!TryInputNumber("Введите число k (сумма цифр):", out k))
            {
                Console.ReadKey();
                return;
            }

            if (k < 1)
            {
                Console.WriteLine("Число k должно быть натуральным.");
                Console.ReadKey();
                return;
            }

            int counter = 0;

            int start = (int)Math.Pow(10, n - 1);
            int end = (int)Math.Pow(10, n);

            for (int number = start; number < end; number++)
            {
                int temp = number;
                int sum = 0;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (sum == k)
                {
                    Console.Write($"{number}, ");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine($"\nНет {n}-значных чисел с суммой цифр {k}.");
            else
                Console.WriteLine("\b\b "); 

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода. Введите корректное число.");
                return false;
            }

            return true;
        }
    }
}