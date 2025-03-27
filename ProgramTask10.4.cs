using System;
namespace project
{
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите число k (0 <= k <= 8): ");
        int k = int.Parse(Console.ReadLine());

        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            if (digit > k)
            {
                sum += digit;
            }
            n /= 10;
        }
        Console.WriteLine("Сумма цифр, больших " + k + ": " + sum);
    }
}
}
