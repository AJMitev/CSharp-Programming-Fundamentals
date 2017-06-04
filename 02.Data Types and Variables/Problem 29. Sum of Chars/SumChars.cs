using System;

public class SumChars
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            char currChar = char.Parse(Console.ReadLine());
            sum += (int)currChar;
        }

        //Output
        Console.WriteLine("The sum equals: {0}",sum);
    }
}
