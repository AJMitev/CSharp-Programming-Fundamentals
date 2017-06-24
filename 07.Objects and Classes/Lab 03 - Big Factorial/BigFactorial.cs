using System;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = 2; i <=n; i++)
        {
            result = result * i;
        }

        Console.WriteLine(result);
    }
}