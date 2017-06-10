using System;
using System.Linq;

public class DropAndSumArray
{
    public static void Main()
    {
        ///Input
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        ///Logic
        //Extract Leftside numbers
        int[] leftDropedNumbers = new int[numbers.Length / 4];

        for (int i = 0; i < leftDropedNumbers.Length; i++)
        {
            leftDropedNumbers[i] = numbers[i];
        }

        //Extract Middle
        int[] reservedNumbers = new int[numbers.Length / 2];

        for (int middle = 0; middle < reservedNumbers.Length; middle++)
        {
            reservedNumbers[middle] = numbers[numbers.Length -reservedNumbers.Length- leftDropedNumbers.Length+middle];
        }

        //Extract Rightside numbers
        int[] rightDropedNumbers = new int[numbers.Length / 4];

        for (int rightIndex = 0; rightIndex < rightDropedNumbers.Length; rightIndex++)
        {
            rightDropedNumbers[rightIndex] = numbers[numbers.Length - rightDropedNumbers.Length + rightIndex];
        }

        int[] foldedNumbers = new int[reservedNumbers.Length];

        for (int i = leftDropedNumbers.Length -1, counter =0 ; i >= 0; i--)
        {
            foldedNumbers[counter] = leftDropedNumbers[i];
            counter++;
        }

        for (int i = rightDropedNumbers.Length - 1, counter = leftDropedNumbers.Length; i >= 0; i--)
        {
            foldedNumbers[counter] = rightDropedNumbers[i];
            counter++;
        }

        //Calculating the sum.

        int[] sumArray = new int[reservedNumbers.Length];

        for (int i = 0; i < sumArray.Length; i++)
        {
            sumArray[i] = foldedNumbers[i] + reservedNumbers[i];
        }

        ///Output
        Console.WriteLine(string.Join(" ", sumArray));
    }
}
