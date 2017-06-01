using System;

public class TextExercises
{
    public static void Main()
    {
        //Input
        string textOne = Console.ReadLine();
        char charOne = char.Parse(Console.ReadLine());
        char charTwo = char.Parse(Console.ReadLine());
        char charThree = char.Parse(Console.ReadLine());
        string textTwo = Console.ReadLine();

        //Output
        Console.WriteLine($"{textOne}\n{charOne}\n{charTwo}\n{charThree}\n{textTwo}");
    }
}