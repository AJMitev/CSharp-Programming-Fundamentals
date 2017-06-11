using System;
using System.Linq;

public class MaxSequence
{
    public static void Main()
    {
        //Input
        int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int bestIndex = 0;
        int bestLenght =0;

        int currentIndex = 0;
        int currentLenght = 1;

        for (int i = 1; i < numbersArray.Length; i++)
        {

            if (numbersArray[i] == numbersArray[i - 1])
            {
                currentLenght++;

                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    bestIndex = currentIndex;
                }
            }
            else
            {
                currentIndex = i;
                currentLenght = 1;
            }
        }


        //Output
        for (int i = bestIndex; i < bestIndex + bestLenght; i++)
        {
            Console.Write(numbersArray[i] + " ");
        }
        Console.WriteLine();
    }
}
