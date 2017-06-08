using System;
using System.Linq;

class SumTwoArrays
{
    static void Main()
    {
        long[] arrayOne = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long[] arrayTwo = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        int n = Math.Max(arrayOne.Length, arrayTwo.Length);
        int lengthOfFirsArray = arrayOne.Length;
        int lengthOfSecondArray = arrayTwo.Length;

        long[] arraysSum = new long[n];
        for (int i = 0; i < arraysSum.Length; i++)
        {
            arraysSum[i] = arrayOne[i % lengthOfFirsArray] + arrayTwo[i % lengthOfSecondArray];
        }

        Console.WriteLine(string.Join(" ", arraysSum));


    }
}