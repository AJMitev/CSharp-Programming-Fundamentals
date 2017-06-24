using System;
using System.Collections.Generic;

using System.Linq;

public class Circle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }
}
public class IntersectionOfCircles
{
    public static void Main()
    {
        double[] firstCirleProporties = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] secondCirleProporties = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var firstCirle = new Circle
        {
            X = firstCirleProporties[0],
            Y = firstCirleProporties[1],
            Radius = firstCirleProporties[2]
        };

        var secondCirle = new Circle
        {
            X = secondCirleProporties[0],
            Y = secondCirleProporties[1],
            Radius = secondCirleProporties[2]
        };

        var result = Intersect(firstCirle, secondCirle);

        if (result)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }

    public static bool Intersect(Circle firstCirle, Circle secondCircle)
    {
        var distance = CalculateDistance(firstCirle, secondCircle);
        bool areIntersect = false;

        if (distance <= (firstCirle.Radius + secondCircle.Radius))
        {
            areIntersect = true;
        }
        return areIntersect;
    }
    public static double CalculateDistance(Circle firstCircle, Circle secondCircle)
    {
        var differenceX = firstCircle.X - secondCircle.X;
        var differenceY = firstCircle.Y - secondCircle.Y;

        var powX = Math.Pow(differenceX, 2);
        var powY = Math.Pow(differenceY, 2);

        return Math.Sqrt(powX + powY);
    }
}
