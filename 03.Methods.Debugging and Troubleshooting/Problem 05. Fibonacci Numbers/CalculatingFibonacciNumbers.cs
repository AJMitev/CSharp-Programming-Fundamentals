using System;

public class CalculatingFibonacciNumbers
{
    public static void Main()
    {
        int fibonacci = int.Parse(Console.ReadLine());
        Console.WriteLine(GetFibonacciNumber(fibonacci));

    }

    public static int GetFibonacciNumber(int fibonacci)
    {
        int f0 = 1;
        int f1 = 1;

        for (int i = 1; i < fibonacci; i++)
        {
            int nextF = f0 + f1;
            f0 = f1;
            f1 = nextF;
        }

        return f1;
    }
}