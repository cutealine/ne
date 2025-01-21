using System;

namespace Variant13
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            int L = 100000;

            for (int n = 2; n < L; n++)
            {
                int c = C(n);

                if (c == 8)
                {
                    S += n;
                }
            }

            Console.WriteLine("Сумма всех n, для которых C(n) = 8 в пределах 100000: " + S);
        }

        static int C(int n)
        {
            int count = 0;

            for (int m = 2; m < n; m++)
            {
                if ((m * m * m) % n == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
