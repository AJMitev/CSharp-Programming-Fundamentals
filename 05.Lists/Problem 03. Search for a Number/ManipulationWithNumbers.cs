using System;
using System.Collections.Generic;
using System.Linq;

public class ManipulationWithNumbers
{
    public static void Main()
    {
        //Input
        var listOfNumbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

        //Logic
        int[] operations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var manipulatedNumbers = new List<int>();

        for (int index = 0; index < operations[0]; index++)
        {
            manipulatedNumbers.Add(listOfNumbers[index]);
        }

        listOfNumbers.RemoveRange(0, operations[0]);
        manipulatedNumbers.RemoveRange(0, operations[1]);

        for (int i = 0; i < manipulatedNumbers.Count; i++)
        {
            listOfNumbers.Insert(i, manipulatedNumbers[i]);
        }

        if (listOfNumbers.Contains(operations[2]))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }

    }
}
