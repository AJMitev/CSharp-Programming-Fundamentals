using System;

public class PrintingTwoPoints
{
    public static void Main()
    {
        //Input
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

    }

    public static string PrintClosestToCenterPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double dOne = Math.Pow(x1, 2) + Math.Pow(y1, 2);
        double dTwo = Math.Pow(x2, 2) + Math.Pow(y2, 2);
        double dTree = Math.Pow(x3, 2) + Math.Pow(y3, 2);
        double dFour = Math.Pow(x4, 2) + Math.Pow(y4, 2);

        if (dOne <= dTwo)
        {
            if (true)
            {

            }
            return $"({x1}, {y1})";
        }
        else
        {
            return $"({x1}, {y1})";
        }
    }
}