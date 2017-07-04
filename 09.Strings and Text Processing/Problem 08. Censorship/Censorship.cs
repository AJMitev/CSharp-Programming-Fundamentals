using System;

public class Censorship
{
    public static void Main()
    {
        string censuredWord = Console.ReadLine();
        string text = Console.ReadLine();

        string result = text.Replace(censuredWord, new string('*', censuredWord.Length));

        Console.WriteLine(result);

    }
}