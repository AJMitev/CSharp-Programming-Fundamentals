using System;

public class Numbers
{
    public static void Main(string[] args)
    {
        //Input
        sbyte numberOne = sbyte.Parse(Console.ReadLine());
        byte numberTwo = byte.Parse(Console.ReadLine());
        short numberThree = short.Parse(Console.ReadLine());
        ushort numberFour = ushort.Parse(Console.ReadLine());
        uint numberFive = uint.Parse(Console.ReadLine());
        int numberSix = int.Parse(Console.ReadLine());
        long numberSeven = long.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"{numberOne}\n{numberTwo}\n{numberThree}\n{numberFour}\n{numberFive}\n{numberSix}\n{numberSeven}");

    }
}