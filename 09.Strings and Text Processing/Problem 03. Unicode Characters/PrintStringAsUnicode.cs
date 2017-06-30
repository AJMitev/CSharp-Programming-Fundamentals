using System;

public class PrintStringAsUnicode
{
    public static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        foreach (var letter in input)
        {
            Console.Write($"\\u{(int)letter:x4}");
        }

        Console.WriteLine();
    }
}