using System;
using System.Collections.Generic;
using System.Linq;

public class PrintResoursesAndQuantities
{
    public static void Main()
    {
        //Input
        var resources = new Dictionary<string, int>();

        while (true)
        {
            string resurceName = Console.ReadLine();

            if (resurceName.Equals("stop"))
            {
                break;
            }
            int resurceQuantity = int.Parse(Console.ReadLine());
            if (resources.ContainsKey(resurceName))
            {
                resources[resurceName] += resurceQuantity;

            }
            else
            {
                resources[resurceName] = resurceQuantity;

            }
        }

        foreach (var resource in resources)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }

    }
}
