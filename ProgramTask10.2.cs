namespace _10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (!TryInputNumber("Введите количество элементов электрической цепи", out n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Количество элементов электрической цепи должно быть > 0");
                Console.ReadKey();
                return;
            }

            double totalResistance = 0;
            for (int i = 1; i <= n; i++)
            {
                int r;
                if (!TryInputNumber($"Введите сопротивление r{i} элемента цепи", out r))
                {
                    Console.ReadKey();
                    return;
                }           
                totalResistance += (1.0 / r);
            }

            Console.WriteLine($"Общее сопротивление цепи:{1 / totalResistance}");
            Console.ReadKey();
        }

            static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}