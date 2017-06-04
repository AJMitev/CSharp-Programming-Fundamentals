using System;

public class PrintingChars
{
    public static void Main()
    {
        //Input
        int numberOfLines = int.Parse(Console.ReadLine());

        string text = string.Empty;

        for (int i = 0; i < numberOfLines; i++)
        {
            char currentChart = char.Parse(Console.ReadLine());
            text = text + currentChart;
        }

        Console.WriteLine($"The word is: {text}");
    }
}
