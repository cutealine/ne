using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A < 100 || A > 999)
            {
                Console.WriteLine("Ошибка: введите трёхзначное число.");
                return;
            }

            int first = A / 100; 
            int second = (A / 10) % 10; 
            int third = A % 10; 

        
            int result = (second * 100) + (third * 10) + first;

            Console.WriteLine($"Полученное число: {result}");
            Console.ReadKey();
        }
    }
}
