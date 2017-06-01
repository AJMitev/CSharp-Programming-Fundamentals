using System;

public class ReversedChars
{
    public static void Main()
    {
        //Input
        char charOne = char.Parse(Console.ReadLine());
        char charTwo = char.Parse(Console.ReadLine());
        char charThree = char.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"{charThree}{charTwo}{charOne}");
    }
}