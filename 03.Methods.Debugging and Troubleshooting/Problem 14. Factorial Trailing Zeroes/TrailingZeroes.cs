using System;
using System.Numerics;

public class TrailingZeroes
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(CalculateZeroes(CalculateFacturial(number)));

    }

    public static BigInteger CalculateFacturial(int number)
    {
        BigInteger facturial = 1;
        for (int i = number; i > 0; i--)
        {
            facturial *= i;
        }
        return facturial;
    }

    public static int CalculateZeroes(BigInteger number)
    {
        
        int zeroCntr = 0;

        while (number % 10 == 0)
        {
            zeroCntr++;

            number /= 10;
        }

        return zeroCntr;
    }
}