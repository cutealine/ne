using System;

namespace project
{
       internal class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Введите значение x для функции y=f(x)");
               var x = double.Parse(Console.ReadLine());

               Console.WriteLine($"f({x}) = {MyFunction(x)}");
               Console.ReadKey();
           }

           static double MyFunction(double x)
           {
               if ( Math.Abs (Math.Sin(x)) > x)
                   return Math.Sin(x);
               else if ( Math.Abs( Math.Sin(x)) < x)
                   return -1*Math.Sin(x);
               else
                   return 0;
           }
       }
}
