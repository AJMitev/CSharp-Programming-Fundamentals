using System;

public class CalculatingCubeProperties
{
    public static void Main()
    {
        //Input
        double lenght = double.Parse(Console.ReadLine());
        string property = Console.ReadLine();
        double result = 0;

        //Logic
        switch (property)
        {
            case "face":
                result = CalculatingFace(lenght);
                break;
            case "space":
                result = CalculatingSpace(lenght);
                break;
            case "volume":
                result = CalculatingVolume(lenght);
                break;
            case "area":
                result = CalculatingArea(lenght);
                break;
            default:
                Console.WriteLine("No such property! Try again....");
                break;
        }

        //Output
        Console.WriteLine("{0:f2}", result);
    }

    public static double CalculatingFace(double lenght)
    {
        double face = Math.Sqrt(2 * (Math.Pow(lenght, 2)));

        return face;
    }

    public static double CalculatingSpace(double lenght)
    {
        double space = Math.Sqrt(3 * Math.Pow(lenght, 2));

        return space;
    }

    public static double CalculatingVolume(double lenght)
    {
        double volume = lenght * lenght * lenght;
        return volume;
    }
    public static double CalculatingArea(double lenght)
    {
        double singleArea = Math.Pow(lenght, 2);
        double area = 6 * singleArea;

        return area;
    }
}