using System;

public class PyramidVolume
{
    public static void Main(string[] args)
    {
        //Input
        double lenght = 0;
        double width = 0;
        double height = 0;

        Console.Write("Length: ");
        lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());

        //Logic
        double volume = (((lenght * width) * height)) / 3;

        //Output
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}