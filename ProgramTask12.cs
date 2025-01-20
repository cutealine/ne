using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        FindElementDivisibleByNumber(array, number);

        CalculateEvenProductInColumns(array);
    }
    static void FindElementDivisibleByNumber(int[,] array, int number)
    {
        bool found = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % number == 0)
                {
                    Console.WriteLine($"Элемент, делящийся на {number}, найден на индексе: [{i}, {j}]");
                    found = true;
                    return;   }    
            }
        }
        if (!found)
        {
            Console.WriteLine($"Нет элементов, делящихся на {number}.");
        }
    }
    static void CalculateEvenProductInColumns(int[,] array)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int product = 1;
            bool hasEven = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, j] % 2 == 0)
                {
                    product *= array[i, j];
                    hasEven = true;
                }
            }
            if (hasEven)
            {
                Console.WriteLine($"Столбец {j}: произведение четных элементов = {product}");
            }
            else
            {
                Console.WriteLine($"Столбец {j}: нет четных элементов.");
            }
        }
    }
