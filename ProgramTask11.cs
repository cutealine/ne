using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string[] words = input
            .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        PrintArray(words);

        CapitalizeFirstLetter(words);
        Console.WriteLine("Слова с заглавной буквой:");
        PrintArray(words);

        double averageLength = CalculateAverageLength(words);
        Console.WriteLine($"Средняя длина слов: {averageLength}");

        string[] reversedWords = ReverseWords(words);
        Console.WriteLine("Слова с изменённым порядком символов:");
        PrintArray(reversedWords);
    }
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    static void CapitalizeFirstLetter(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (!string.IsNullOrEmpty(array[i]))
            {
                array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1);
            }
        }
    }
    static double CalculateAverageLength(string[] array)
    {
        if (array.Length == 0) return 0;
        
        double totalLength = array.Sum(word => word.Length);
        return totalLength / array.Length;
    }
    static string[] ReverseWords(string[] array)
    {
        return array.Select(word => new string(word.Reverse().ToArray())).ToArray();
    }
}
