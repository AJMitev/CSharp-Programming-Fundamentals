using System;

public class Greeting
{
    public static void Main()
    {
        //Input
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
    }
}
