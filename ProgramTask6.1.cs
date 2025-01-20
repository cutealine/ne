﻿using System; 

namespace project
{
internal class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.WriteLine ("Введите текст на русском языке: "); 
        var text = Console.ReadLine (); 
        Console.WriteLine (Translate(text)); 
 
        Console.ReadKey (); 
    } 
 
    static string Translate(string s) 
    { 
         return s.ToUpper() 
        .Replace("A", "4") 
        .Replace("B", "8") 
        .Replace("C", "(") 
        .Replace("D", "|)") 
        .Replace("E", "3") 
        .Replace("F", "|=") 
        .Replace("G", "6") 
        .Replace ("H", "|-|") 
        .Replace("I", "!") 
        .Replace("J", ")") 
        .Replace ("K", "|<") 
        .Replace ("L", "1") 
        .Replace("M", "|\\/|") 
        .Replace("N", "|\\|") 
        .Replace("O", "0") 
        .Replace("P", "|>") 
        .Replace("Q", "9") 
        .Replace("R", "|2") 
        .Replace("S", "5") 
        .Replace("T", "7") 
        .Replace("U", "|_|") 
        .Replace("V", "\\/") 
        .Replace("W", "\\/\\/") 
        .Replace("X", "<>") 
        .Replace("Y", "'/") 
        .Replace("Z", "2"); 
    } 
}
}
