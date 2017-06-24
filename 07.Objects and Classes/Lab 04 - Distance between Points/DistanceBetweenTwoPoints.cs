using System;
using System.Collections.Generic;
using System.Linq;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

public class DistanceBetweenTwoPoints
{
    public static void Main()
    {
        double[] firstPointProporties = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] secondPointProporties = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var firstPoint = new Point
        {
            X = firstPointProporties[0],
            Y = firstPointProporties[1]
        };

        var secondPoint = new Point
        {
            X = secondPointProporties[0],
            Y = secondPointProporties[1]
        };

        var result = CalculateDistance(firstPoint, secondPoint);

        Console.WriteLine(result);
    }
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var differenceX = firstPoint.X - secondPoint.X;
        var differenceY = firstPoint.Y - secondPoint.Y;

        var powX = Math.Pow(differenceX, 2);
        var powY = Math.Pow(differenceY, 2);

        return Math.Sqrt(powX + powY);
    }
}
