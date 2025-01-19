namespace _10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число k");

            int k;

            if (!int.TryParse(Console.ReadLine(), out k) || 0 >= k || k >= 8)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var sum = 0;
            var temp = n;

            while (temp > 0)
            {
                var digit = temp % 10;
                if (digit > k)
                {
                    sum += digit;
                }
                temp /= 10;
            }

            Console.WriteLine($"Сумма цифр числа {n}, больших числа {k} равна {sum}");

            Console.ReadKey();
        }
    }
}