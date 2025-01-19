using System;

namespace _10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; 

            // Изменено условие проверки диапазона для a
            if (!TryInputNumber("Введите число a:", out a) || (a <= 1 || a >= 2))
            {
                Console.WriteLine("Число должно быть в диапазоне (1, 2)");
                Console.ReadKey();
                return;
            }

            double sum = 0;
            int n = 0;

            // Цикл для вычисления суммы
            do
            {
                sum += (1.0 / Math.Pow(2, n));
                n++;
                Console.WriteLine(sum); 
            } while (sum <= a); 

            Console.WriteLine($"Наименьшее натуральное число n равно {n-1}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out double number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}