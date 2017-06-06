using System;

public class ReversingOrder
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(ReorderNumbers(number));

    }

    public static double ReorderNumbers(double number)
    {
        string reversedNumber = number.ToString();
        string reversedString = string.Empty;

        for (int i = reversedNumber.Length - 1; i >= 0; i--)
        {
            reversedString += reversedNumber[i];
        }

        double newOrderedNumber = double.Parse(reversedString);
        return newOrderedNumber;
    }

}