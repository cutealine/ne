using System;

namespace project
{
class Program
{
    static double f(double x, double a, double b, double c, double d)
    {
        return Math.Pow(x, 4) - a * Math.Pow(x, 3) - b * Math.Pow(x, 2) - c * x - d;
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Введите d: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Введите ε: ");
        double eps = double.Parse(Console.ReadLine());

        int n = 1;
        while (f(n, a, b, c, d) <= 0) n++;

        double left = 0, right = n, mid;

        while (right - left > eps)
        {
            mid = (left + right) / 2;
            if (f(mid, a, b, c, d) * f(left, a, b, c, d) <= 0)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }

        Console.WriteLine("Найденный корень: " + (left + right) / 2);
    }
}
}
