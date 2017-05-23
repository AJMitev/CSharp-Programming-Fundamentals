using System;

public class Summing
{
    public static void Main()
    {
        //Input
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());

        double result = numberOne + numberTwo;
        //Output
        Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
    }
}

