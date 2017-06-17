using System;
using System.Collections.Generic;
using System.Linq;

public class OddFilter
{
    public static void Main()
    {
        //Input
        var numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

        var selectedNumbers = numbers.Where(x => x % 2 == 0).ToList();

        var averageNumber = selectedNumbers.Average();

        for (int i = 0; i <  selectedNumbers.Count(); i++)
        {
            if (selectedNumbers[i] > averageNumber)
            {
                selectedNumbers[i]++;
            }

            if (selectedNumbers[i] <= averageNumber)
            {
                selectedNumbers[i]--;
            }

        }

        // var filteredOdds = selectedNumbers.Where(x => x % 2 == 1);

        foreach (int number in selectedNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
