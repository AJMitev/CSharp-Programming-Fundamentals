using System;

public class Rotator
{
    public static void Main()
    {
        //Input
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        //Logic

        Console.WriteLine($"Before:\na = {a}\nb = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After:\na = {a}\nb = {b}");
    }
}