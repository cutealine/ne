using System;

namespace _10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, epsilon;

            Console.WriteLine("Введите коэффициенты a, b, c, d и точность:");

            if (!double.TryParse(Console.ReadLine(), out a) ||
                !double.TryParse(Console.ReadLine(), out b) ||
                !double.TryParse(Console.ReadLine(), out c) ||
                !double.TryParse(Console.ReadLine(), out d) ||
                !double.TryParse(Console.ReadLine(), out epsilon) || epsilon <= 0)
            {
                Console.WriteLine("Ошибка ввода.");
                Console.ReadKey();
                return;
            }

            double left = 0, right = 0, mid = 0;
            for (int n = 1; ; n++)
            {
                right = n;

                if (Function(right, a, b, c, d) > 0)
                {
                    break;
                }
            }

            double fLeft = Function(left, a, b, c, d);
            double fRight = Function(right, a, b, c, d);

            while (right - left > epsilon)
            {
                mid = (left + right) / 2;
                double fMid = Function(mid, a, b, c, d);

                if (Math.Abs(fMid) < epsilon)
                {
                    break;
                }

                if (fLeft * fMid < 0)
                {
                    right = mid;
                    fRight = fMid;
                }
                else
                {
                    left = mid;
                    fLeft = fMid;
                }
            }

            Console.WriteLine($"Примерный корень уравнения: {mid:F6}");
            Console.ReadKey();
        }

        static double Function(double x, double a, double b, double c, double d)
        {
            return Math.Pow(x, 4) - a * Math.Pow(x, 3) - b * Math.Pow(x, 2) - c * x - d;
        }
    }
}