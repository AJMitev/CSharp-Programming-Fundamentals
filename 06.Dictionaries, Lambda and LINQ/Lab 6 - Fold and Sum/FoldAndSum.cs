using System;
using System.Collections.Generic;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        //Input
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int k = arr.Length / 4;

        int[] row1left = arr.Take(k).Reverse().ToArray();
        int[] row1right = arr.Reverse().Take(k).ToArray();
        int[] row1 = row1left.Concat(row1right).ToArray();
        int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

        var sumArr = row1.Select((x, index) => x + row2[index]);

        //Output
        Console.WriteLine(string.Join(" ", sumArr));

    }
}