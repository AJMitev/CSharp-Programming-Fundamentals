using System;

public class RectangleArea
{
    public static void Main()
    {
        //Input
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double area = a * b;
        //Output
        Console.WriteLine($"{area:f2}");
    }
}