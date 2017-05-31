using System;

public class CalculatingExactSum
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        decimal number = 0m;
        decimal result = 0m;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            result = result + number;
        }

        //Output
        Console.WriteLine(result);

    }
}
