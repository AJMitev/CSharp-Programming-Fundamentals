using System;
using System.Linq;
using System.Numerics;

public class ConvertFrom10ToN
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();

        BigInteger number = BigInteger.Parse(input[1]);
        int baseN = int.Parse(input[0]);

       var result = ConvertFromTenToN(number, baseN);
        Console.WriteLine(result);
    }

    private static string ConvertFromTenToN(BigInteger number, int baseN)
    {
        var result = string.Empty;

        while (number > 0)
        {
            var reminder = number % baseN;

            result = reminder + result;
            number /= baseN;       
        }

        return result;
    }
}
