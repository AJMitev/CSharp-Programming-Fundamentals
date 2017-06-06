using System;

public class CalculatingArea
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = CalculatingTriangleArea(width, height);
        Console.WriteLine(area);

    }

    public static double CalculatingTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
}
