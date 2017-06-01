using System;

public class PyramidVolume
{
    public static void Main(string[] args)
    {
        //Input
        Console.Write("Length: ");
        double lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        //Logic
        double volume = (((lenght * width) * height)) / 3;

        //Output
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}