using System;

public class GetCenter
{
    public static void Main()
    {
        //Input
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(PrintClosestToCenterPoint(x1, y1, x2, y2));

    }

    public static string PrintClosestToCenterPoint(double x1, double y1, double x2, double y2)
    {
        double dOne = Math.Pow(x1, 2) + Math.Pow(y1, 2);
        double dTwo = Math.Pow(x2, 2) + Math.Pow(y2, 2);

        if (dOne >= dTwo)
        {
            return $"({x2}, {y2})";
        }
        else
        {
            return $"({x1}, {y1})";
        }
    }
}