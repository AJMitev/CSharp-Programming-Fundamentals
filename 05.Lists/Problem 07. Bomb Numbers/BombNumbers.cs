using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        //Input
        var seuqnce = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
        int[] bombProperties = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Logic
        int bomb = bombProperties[0];
        int power = bombProperties[1];

        for (int i = 0; i < seuqnce.Count; i++)
        {
            if (seuqnce[i].Equals(bomb))
            {
                int left = Math.Max(i - power, 0);
                int right = Math.Min(i + power, seuqnce.Count - 1);

                int lenght = right - left + 1;
                seuqnce.RemoveRange(left, lenght);
                i = 0;
            }
   
        }

        Console.WriteLine(seuqnce.Sum());
    }
}