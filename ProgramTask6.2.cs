using System; 
 
internal class Program 
{ 
    static void Main(string[] args) 
    { 
        string word = "апельсин"; 
 
 
        string word1 = word.Substring(1,2) + word.Substring(7, 1) + word.Substring(4, 1); 
 
     
        string word2 = word.Substring(5,1) + word.Substring(1,1) + word.Substring(0,1) + word.Substring(7,1) + word.Substring(6,1) + word.Substring(2,3); 
 
        Console.WriteLine("Первое слово: " + word1); 
        Console.WriteLine("Второе слово: " + word2); 
    } 
}