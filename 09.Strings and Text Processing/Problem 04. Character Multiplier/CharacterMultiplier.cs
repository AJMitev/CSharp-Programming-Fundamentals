using System;
using System.Linq;
using System.Numerics;

public class CharacterMultiplier
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();

        var result = Multiplier(input);
        Console.WriteLine(result);
    }

    private static BigInteger Multiplier(string[] input)
    {
        char[] charArrOne = input[0].ToCharArray();
        char[] charArrTwo = input[1].ToCharArray();

        BigInteger result = 0;
        int longer = charArrOne.Length - charArrTwo.Length;
        int lastRemindedIndex = Math.Min(charArrOne.Length, charArrTwo.Length);

        for (int i = 0; i < Math.Min(charArrOne.Length, charArrTwo.Length); i++)
        {
            result += charArrOne[i] * charArrTwo[i];
        }

        if (longer > 0)
        {
            for (int i = 0; i < longer; i++)
            {
                result += charArrOne[lastRemindedIndex + i];
            }
        }
        else if (longer < 0)
        {
            longer = Math.Abs(longer);

            for (int i = 0; i < longer; i++)
            {
                result += charArrTwo[lastRemindedIndex + i];
            }
        }

        return result;
    }
}