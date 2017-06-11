using System;
using System.Linq;

public class CompareLeftAndRightSideOfArray
{
    public static void Main()
    {
        //Input
        int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        bool isFound = false;

        for (int i = 0; i < numbersArray.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = i - 1; j >= 0; j--)
            {
                leftSum += numbersArray[j];
            }

            for (int j = i + 1; j < numbersArray.Length; j++)
            {
                rightSum += numbersArray[j];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                isFound = true;
                break;
            }
        }

        //Output
        if (!isFound) Console.WriteLine("no");
    }
}