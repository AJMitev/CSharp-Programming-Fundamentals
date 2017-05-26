using System;

public class MagicLetter
{
    public static void Main()
    {
        //Input
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char ignoredLetter = char.Parse(Console.ReadLine());

        //Logic
        for (char a = firstLetter; a <= secondLetter; a++)
        {
            for (char b = firstLetter; b <= secondLetter; b++)
            {
                for (char c = firstLetter; c <= secondLetter; c++)
                {
                    if (a.Equals(ignoredLetter) || b.Equals(ignoredLetter) || c.Equals(ignoredLetter))
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write($"{a}{b}{c} ");
                    }
                }
            }
        }
    }
}