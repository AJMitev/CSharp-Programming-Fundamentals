using System;
using System.Linq;

public class IncraseSequence
{
    public static void Main()
    {
        //Input
        int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int sequenceIndex = 0;
        int sequenceLenght = 0;

        int currentIndex = 0;
        int currentLenght = 1;

        for (int i = 1; i < numbersArray.Length; i++)
        {

            if (numbersArray[i] - numbersArray[i - 1] >= 1)
            {
                currentLenght++;

                if (currentLenght > sequenceLenght)
                {
                    sequenceLenght = currentLenght;
                    sequenceIndex = currentIndex;
                }
            }
            else
            {
                currentIndex = i;
                currentLenght = 1;
            }
        }

        //Output
        for (int i = sequenceIndex; i < sequenceIndex + sequenceLenght; i++)
        {
            Console.Write(numbersArray[i] + " ");
        }

        Console.WriteLine();
    }
}
