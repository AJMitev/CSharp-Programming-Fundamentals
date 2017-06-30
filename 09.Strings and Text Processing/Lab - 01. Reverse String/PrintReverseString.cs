using System;

public class PrintReverseString
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var reversed = GetReversed(text);

        Console.WriteLine(reversed);
    }

    private static string GetReversed(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;

        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }

        return reverse;
    }
}

