using System;
namespace project
{
class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.Write("Введите целое число для проверки: ");
        if (int.TryParse(Console.ReadLine(), out int divisor))
        {
            FindDivisibleElement(array, divisor);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }

        CalculateEvenProduct(array);
    }

    static void FindDivisibleElement(int[,] array, int divisor)
    {
        bool found = false;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % divisor == 0)
                {
                    Console.WriteLine($"Элемент {array[i, j]} делится на {divisor} " +
                                      $"находится по индексам: [{i}, {j}]");
                    found = true;
                    return; 
                }
            }
        }

        if (!found)
        {
            Console.WriteLine($"В массиве нет элементов, делящихся на {divisor}.");
        }
    }

    static void CalculateEvenProduct(int[,] array)
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
                Console.WriteLine($"Произведение четных элементов столбца {j}: {product}");
            }
            else
            {
                Console.WriteLine($"В столбце {j} нет четных элементов.");
            }
        }
    }
}
}
