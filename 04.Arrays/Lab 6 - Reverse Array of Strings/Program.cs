using System;

class ReversingSomeString
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] arr = values.Split(' ');

        Array.Reverse(arr);
        Console.WriteLine(string.Join(" ", arr));
    }
}