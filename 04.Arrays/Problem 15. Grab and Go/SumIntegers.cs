using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        //Input
        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int element = int.Parse(Console.ReadLine());

        //Logic

        int lastIndexOfElement = 0;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int currentIndex = i;

            if (arrayOfNumbers[i].Equals(element))
            {
                lastIndexOfElement = currentIndex;
            }
        }

        long sumOfPreviusNumbers = 0;

        if (lastIndexOfElement != 0)
        {

            for (int i = lastIndexOfElement - 1; i >= 0; i--)
            {
                sumOfPreviusNumbers += arrayOfNumbers[i];
            }

            Console.WriteLine(sumOfPreviusNumbers);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");

        }
    }
}