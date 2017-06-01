using System;

public class FloatingNumbers
{
    public static void Main()
    {
        //Input
        decimal numberOne = decimal.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());
        decimal numberThree = decimal.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"{numberOne}\n{numberTwo}\n{numberThree}");

    }
}