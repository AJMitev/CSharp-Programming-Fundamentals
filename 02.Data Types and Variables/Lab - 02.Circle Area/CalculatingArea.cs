using System;

public class CalculatingArea
{
    public static void Main()
    {
        //Input
        double r = double.Parse(Console.ReadLine());

        //Logic
        double circulArea = Math.PI * r * r;

        //Output
        Console.WriteLine($"{circulArea:f12}");
    }
}
