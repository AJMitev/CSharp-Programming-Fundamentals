using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(CalculateFacturial(number));

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
}
