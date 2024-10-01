using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число:");
        string input = Console.ReadLine();

        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            string result = input.Substring(1) + input[0];
            Console.WriteLine("Полученное число: " + result);
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное трехзначное число.");
        }

        Console.ReadKey();
    }
}
