using System;

public class NumberCheker
{
    public static void Main()
    {
        //Input
        string input = Console.ReadLine();

        //Logic
        try
        {
            long number = long.Parse(input);
            Console.WriteLine("integer");
        }
        catch (Exception)
        {

            Console.WriteLine("floating-point");
        }


    }
}