using System;

public class PowerTheNumber
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(Power(number, power));
    }
    public static double Power(double number, int power)
    {
        double result = 1d;
        for (double i = 0; i < power; i++)
        {

            result *= number;
        }
        return result;
    }
}
