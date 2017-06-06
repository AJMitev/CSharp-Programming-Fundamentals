using System;

public class Greetings
{

    public static void Main()
    {
        PrintGreeting();
    }

    public static void PrintGreeting()
    {
        string username = Console.ReadLine();
        Console.WriteLine($"Hello, {username}!");
    }
}
