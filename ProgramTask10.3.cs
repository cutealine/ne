using System;
namespace project
{
class Program
{
    static void Main()
    {
        Console.Write("Введите число a (1 < a < 2): ");
        double a = double.Parse(Console.ReadLine());
        int n = 0;
        double sum = 0;

        while (sum <= a)
        {
            n++;
            sum += 1.0 / Math.Pow(2, n);
        }
        Console.WriteLine("Наименьшее натуральное число n: " + n);
    }
}
}
