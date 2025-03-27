using System;
namespace project
{
class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов n: ");
        int n = int.Parse(Console.ReadLine());
        double[] resistances = new double[n];
        double totalResistance = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите сопротивление элемента {i+1}: ");
            resistances[i] = double.Parse(Console.ReadLine());
            totalResistance += 1 / resistances[i];
        }

        totalResistance = 1 / totalResistance;
        Console.WriteLine("Общее сопротивление: " + totalResistance);
    }
}﻿
}
