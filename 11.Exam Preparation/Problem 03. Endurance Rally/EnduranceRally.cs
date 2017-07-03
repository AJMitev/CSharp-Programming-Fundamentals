using System;
using System.Collections.Generic;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        //Input
        string[] drivers = Console.ReadLine().Split().ToArray();
        double[] trackLayouts = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] checkpointsIndexes =  Console.ReadLine().Split().Select(double.Parse).ToArray();

        for (int i = 0; i < trackLayouts.Length; i++)
        {
            if (!checkpointsIndexes.Contains(i))
            {
                trackLayouts[i] *= -1;
            }
        }

        foreach (var driver in drivers)
        {
            double fuel = driver[0];

            for (int i = 0; i < trackLayouts.Length; i++)
            {

                fuel += trackLayouts[i];

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    break;
                }
               
            }

            if (fuel > 0)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }
        }
    }
}