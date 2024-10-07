using System;
internal class Program{
static void Main(string[] agrs){
Console.WriteLine("Введите число x: ");
var x = double.Parse(Console.ReadLine());

var y = MyFuncion(x);
Console.WriteLine("f(x) = " + y);

Console.ReadKey();
}

static double MyFuncion(double x)
{
    //throw new NotImplementedException();
    return Math.Sqrt((2*x + Math.Sin(3*x))/3.56);
}
}
