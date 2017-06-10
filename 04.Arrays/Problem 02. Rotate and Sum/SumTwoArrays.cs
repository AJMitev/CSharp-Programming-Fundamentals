using System;
using System.Linq;

public class SumTwoArrays
{
    public static void Main()
    {
        //Input
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long rotator = long.Parse(Console.ReadLine());

        //Logic
        long[] sumArr = new long[numbers.Length];

        for (long r = 0; r < rotator; r++)
        {
            RotateArray(numbers);

            for (long i = 0; i < numbers.Length; i++)
            {
                sumArr[i] += numbers[i];
            }
        }

        //Output
        Console.WriteLine(string.Join(" ", sumArr));

    }

    private static void RotateArray(long[] numbers)
    {
        long lastElement = numbers[numbers.Length-1];

        for (int i = numbers.Length-1; i > 0 ; i--)
        {
            numbers[i] = numbers[i - 1];
        }
        numbers[0] = lastElement;
    }
}
