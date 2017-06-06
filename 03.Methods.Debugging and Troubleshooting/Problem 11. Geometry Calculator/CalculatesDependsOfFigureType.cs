using System;

public class CalculatesDependsOfFigureType
{
    public static void Main()
    {
        //Input
        string figureType = Console.ReadLine();

        double side = 0.00;
        double height = 0.00;
        double radius = 0.00;
        double wight = 0.0;

        switch (figureType.ToLower())
        {
            case "triangle":
                side = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculateTriangleArea(side, height));
                break;
            case "square":
                side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculateSqareArea(side));
                break;
            case "rectangle":
                wight = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculateRectangleArea(wight, height));
                break;
            case "circle":
                radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculateCircleArea(radius));
                break;
            default:
                Console.WriteLine("No such type figure!");
                break;
        }
    }

    public static double CalculateTriangleArea(double side, double height)
    {
        double area = (side * height) / 2;

        return area;
    }

    public static double CalculateSqareArea(double side)
    {
        double area = side * side;
        return area;
    }

    public static double CalculateRectangleArea(double wight, double height)
    {
        double area = wight * height;
        return area;
    }

    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }
}
