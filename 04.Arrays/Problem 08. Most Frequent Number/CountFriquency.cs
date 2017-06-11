using System;
using System.Linq;

public class CountFriquency
{
    public static void Main()
    {
        //Input
        int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int mostFrequency = 0;
        int mostFrequentNumber = 0;

        for (int i = 0; i < numbersArray.Length; i++)
        {

            int currentFrequency = 1;

            for (int g =  i; g < numbersArray.Length; g++)
            {

                if (numbersArray[i].Equals(numbersArray[g]))
                {

                    currentFrequency++;

                    if (currentFrequency > mostFrequency)
                    {
                        mostFrequency = currentFrequency;
                        mostFrequentNumber = numbersArray[g];
                    }
                }
            }
        }

        //Output
        Console.WriteLine(mostFrequentNumber);
    }
}