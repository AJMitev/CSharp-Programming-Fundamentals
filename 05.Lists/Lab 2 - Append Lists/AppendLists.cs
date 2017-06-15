using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
    public static void Main()
    {
        //Input
        string input = Console.ReadLine();

        //Logic
        var nums = input.Split('|').ToList();
        List<string> results = new List<string>();

        for (int i = nums.Count - 1; i >= 0; i--)
        {
            results.Add(string.Join(" ", nums[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries)));
        }

        //Result
        Console.WriteLine(string.Join(" ", results));
    }
} 