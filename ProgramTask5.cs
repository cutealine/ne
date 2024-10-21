using System;
using System.Net.Http.Headers;
internal class Program
{
    static void Main(string[] args)
    {
        double y = F(2,5,5)+F(3, 7, 5)+F(5, 11, 11);
        Console.WriteLine("x = " + Math.Round(y,3));

        Console.ReadKey();
    }
 static double F(double a, double b, double c)
 {
    return (a+Math.Sin(a))/(b+Math.Cos(c));
 }

}