using System;

public class Plural
{
    public static void Main()
    {
        //Input
        string noun = Console.ReadLine();

        //Logic
        int length = noun.Length - 1;
        string suffix = string.Empty;

        if (noun.EndsWith("y"))
        {
            noun = noun.Remove(length, 1);
            suffix = "ies";
        }
        else if (noun.EndsWith("o") || 
            noun.EndsWith("ch") || 
            noun.EndsWith("s") || 
            noun.EndsWith("sh") || 
            noun.EndsWith("x") || 
            noun.EndsWith("z"))
        {
            suffix = "es";
        }
        else
        {
            suffix = "s";
        }

        //Output
        Console.WriteLine($"{noun}{suffix}");
    }
}