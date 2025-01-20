using System;
namespace project 
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра тетраэдра:");
        double edgeLength = double.Parse(Console.ReadLine());

        double volume = Math.Pow(edgeLength, 3) / (6 * Math.Sqrt(2));
        
        double surfaceArea = Math.Sqrt(3) * Math.Pow(edgeLength, 2);

        Console.WriteLine("Объем тетраэдра: " + Math.Round(volume, 3));
        Console.WriteLine("Площадь поверхности тетраэдра: " + Math.Round(surfaceArea, 3));
        Console.ReadKey();
    }
  }
}
