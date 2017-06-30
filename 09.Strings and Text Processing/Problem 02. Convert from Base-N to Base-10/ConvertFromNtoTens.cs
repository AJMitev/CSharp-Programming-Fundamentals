using System;
using System.Linq;
using System.Numerics;

public class ConvertFromNtoTens
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();

        BigInteger number = BigInteger.Parse(input[1]);
        int baseN = int.Parse(input[0]);

        var result = ConvertFromNtoDecimal(number, baseN);
        Console.WriteLine(result);
    }

    private static BigInteger ConvertFromNtoDecimal(BigInteger number, int baseN)
    {
        var numberAsString = number.ToString();

        BigInteger result = new BigInteger(0);
        for (int power = 0; power < numberAsString.Length; power++)
        {
            var num = int.Parse(numberAsString[numberAsString.Length-1-power].ToString());

            result += num * BigInteger.Pow(baseN, power);
        }

        return result;
    }
}