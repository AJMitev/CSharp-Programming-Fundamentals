using System;
using System.Collections.Generic;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        //Input
        string[] inputNumbers = Console.ReadLine().Split(' ').ToArray();

        //Logic
        int sum = 0;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            string currentNumber = inputNumbers[i];
            string reversedNumber = string.Join("",currentNumber.Reverse());

            sum += int.Parse(reversedNumber);
        }

        Console.WriteLine(sum);
    }
}
