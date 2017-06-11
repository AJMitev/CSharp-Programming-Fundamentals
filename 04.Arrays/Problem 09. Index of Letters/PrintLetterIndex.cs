using System;
using System.Linq;

public class PrintLetterIndex
{
    public static void Main()
    {
        //Input
        string text = Console.ReadLine();

        //Logic
        foreach (char symbol in text)
        {

            Console.WriteLine($"{symbol} -> {symbol-97}");

        }
    }
}