using System;

namespace project {
class Program
{
    static void Main()
    {
        long sum = 0; 
        for (int n = 2; n < 100000; n++) 
        {
            if (C(n) == 8)
            {
                sum += n;
            }
        }
        Console.WriteLine("Сумма всех n < 100000 для которых C(n) = 8: " + sum);
    }

    static int C(int n) 
    {
        int count = 0;
        for (int m = 2; m < n; m++)
        {
            if (ModularCube(m, n) == 1)
            {
                count++;
            }
        }
        return count; 
    }

    static int ModularCube(int m, int n) 
    {
        return (m * m % n * m % n) % n;
    }
}
}
