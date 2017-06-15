using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveReversPrint
{
    public static void Main()
    {
        //Input
        List<int> listOfNumbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

        //Logic
        listOfNumbers.Reverse();
        List<int> result = new List<int>();
        bool isEmpty = true;

        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] > 0)
            {
               result.Add(listOfNumbers[i]);
                isEmpty = false;
            }
        }

        //Output

        if (isEmpty)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result));
        }

    }
}
