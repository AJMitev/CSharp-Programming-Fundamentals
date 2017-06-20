using System;
using System.Collections.Generic;
using System.Linq;

public class DecodeMessage
{
    public static void Main()
    {
        //Input
        char[] input = Console.ReadLine().ToCharArray();

        //Logic
        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        List<int> numbersList = new List<int>();
        List<char> nonNumbersList = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (numbers.Contains(input[i]))
            {
                var currChar = input[i].ToString();
                int currentNum = int.Parse(currChar);
               numbersList.Add(currentNum);
            }
            else
            {
                nonNumbersList.Add(input[i]);
            }
        }

        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();

        takeList.AddRange(numbersList.Where((number, index) => index % 2 == 0));
        skipList.AddRange(numbersList.Where((number, index) => index % 2 == 1));

        int takeAndSkipSum = 0;
        var result = new List<string>();

        for (int i = 0; i < takeList.Count(); i++)
        {
            var decoded = String.Concat(nonNumbersList.Skip(takeAndSkipSum).Take(takeList[i]));
            result.Add(decoded);

            takeAndSkipSum += skipList[i] + takeList[i];
        }


        foreach (string s in result)
        {
            Console.Write(s);
        }
        Console.WriteLine();
    }
}
