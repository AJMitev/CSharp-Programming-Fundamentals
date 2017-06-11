using System;
using System.Linq;

public class CountPairs
{
    public static void Main()
    {
        //Input
        int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());

        //Logic
        int pairsCntr = 0;

        for (int i = 0; i < numbersArray.Length; i++)
        {

            for (int j = i; j < numbersArray.Length; j++)
            {
                if (Math.Abs(numbersArray[i]-numbersArray[j]).Equals(difference))
                {
                    pairsCntr++;

                }
            }

        }

        //Output
        Console.WriteLine(pairsCntr);
    }
}