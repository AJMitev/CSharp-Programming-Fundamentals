using System;

public class BooleanVariable
{
    public static void Main()
    {
        //Input
        bool input = Convert.ToBoolean(Console.ReadLine());

        //Output
        if (input == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}