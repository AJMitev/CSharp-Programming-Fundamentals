using System;

public class Multiplying
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(SumOfEvenAndDigits(number));
    }

    public static int SumOfEvenAndDigits(int number)
    {
        return Math.Abs(GetSumOfDigits(number, 0) * GetSumOfDigits(number, 1));

    }

    public static int GetSumOfDigits(int number, int reminder)
    {
        int result = 0;

        foreach (char symbol in number.ToString())
        {
            int digit = symbol - '0';
            if (digit % 2 == reminder)
            {
                result += digit;
            }
        }
        return result;
    }
}