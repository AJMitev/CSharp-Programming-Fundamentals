using System;

public class Compairing
{
    public static void Main()
    {
        //Input
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        //Logic
        double precision = 0.000001;

        double difference = Math.Abs(a - b);

        if (difference > precision)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}