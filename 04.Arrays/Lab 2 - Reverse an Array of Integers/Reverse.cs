using System;

public class Reverse
{
    public static void Main()
    {
        int numberOfArray = int.Parse(Console.ReadLine());
        int[] arrayOfIntegers = new int[numberOfArray];

        for (int i = 0; i < numberOfArray; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            arrayOfIntegers[i] = currentNum;
        }
        for (int i = numberOfArray; i > 0; i--)
        {
            Console.WriteLine(arrayOfIntegers[i - 1]);
        }
    }
}