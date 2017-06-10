using System;
using System.Linq;

public class LargestCommonEnd
{
    public static void Main()
    {
        //Input
        string[] firstInput = Console.ReadLine().Split(' ');
        string[] secondInput = Console.ReadLine().Split(' ');

        int maxLength = Math.Min(firstInput.Length, secondInput.Length);
        int leftCntr = 0;
        int rightCntr = 0;
        int breaker = 0;
        string[] commonPart = new string[maxLength];


        //Left Side
        for (int i = 0; i < maxLength; i++)
        {
            if (firstInput[i] == secondInput[i])
            {
                leftCntr++;
                commonPart[i] = firstInput[i];
            }
        }

        //Right Side
        for (int i = maxLength; i > 0; i--)
        {
            if (firstInput[firstInput.Length - 1 - breaker] == secondInput[secondInput.Length - 1 - breaker])
            {
                rightCntr++;
                breaker++;
                commonPart[commonPart.Length - i] = firstInput[firstInput.Length - 1 - breaker];
            }
        }

        if (leftCntr > 0)
        {
            Console.WriteLine(leftCntr);
        }
        else if (rightCntr > 0)
        {
            Console.WriteLine(rightCntr);
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}