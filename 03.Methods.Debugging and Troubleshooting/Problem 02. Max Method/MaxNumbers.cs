using System;

public class MaxNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int maximumOfFirstTwoNumbers = GetMin(firstNumber, secondNumber);
        int result = GetMax(maximumOfFirstTwoNumbers, thirdNumber);
        Console.WriteLine(result);

    }

    public static int GetMin(int firstNumber, int secondNumber)
    {

        if (firstNumber < secondNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }

    public static int GetMax(int maximumOfFirstTwoNumbers, int thirdNumber)
    {
        if (maximumOfFirstTwoNumbers < thirdNumber)
        {
            return thirdNumber;
        }
        else
        {
            return maximumOfFirstTwoNumbers;
        }
    }
}