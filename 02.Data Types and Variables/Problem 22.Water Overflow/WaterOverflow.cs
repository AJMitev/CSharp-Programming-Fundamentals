using System;

public class WaterOverflow
{
    public static void Main()
    {
        //Input
        byte inputs = byte.Parse(Console.ReadLine());

        //Logic
        byte tankCapacityLeft = 255;
        byte litersInTank = 0;

        for (int i = 0; i <inputs; i++)
        {
            short curretnQuantity = short.Parse(Console.ReadLine());

            if (curretnQuantity >=0)
            {
                if (tankCapacityLeft < curretnQuantity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTank += (byte)curretnQuantity;
                    tankCapacityLeft -= (byte)curretnQuantity;
                }

            }
            
        }

        Console.WriteLine(litersInTank);
    }
}