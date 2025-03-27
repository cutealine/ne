using System;
using System.Collections.Generic;

namespace project
{
class Program
{
    static List<int> numbers = new List<int>();

    static void FindNumbers(int n, int k, int current, int sum, int digits)
    {
        if (digits == n)
        {
            if (sum == k) numbers.Add(current);
            return;
        }

        for (int i = 0; i <= 9; i++)
        {
            if (digits == 0 && i == 0) continue; // избежать ведущих нулей
            FindNumbers(n, k, current * 10 + i, sum + i, digits + 1);
        }
    }

    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите число k (k <= 9n): ");
        int k = int.Parse(Console.ReadLine());

        FindNumbers(n, k, 0, 0, 0);

        Console.WriteLine("Числа:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
}
