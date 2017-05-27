using System;

public class Megapixels
{
    public static void Main()
    {
        //Input
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        //Logic
        double megapixels = (width * height) / 1000000.00;

        //Output
        Console.WriteLine("{0}x{1} => {2}MP",width,height,Math.Round(megapixels,1));
    }
}