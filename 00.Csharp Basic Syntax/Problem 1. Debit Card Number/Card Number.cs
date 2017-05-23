using System;

public class PrintingCardNumber
{
    public static void Main()
    {
        //Input
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());
        int numberFour = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"{numberOne:d4} {numberTwo:d4} {numberThree:d4} {numberFour:d4}");
    }
}