using System;
namespace project
{
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (double)i / (i + 1);
        }
        Console.WriteLine("Сумма: " + sum);
    }
}﻿
}
