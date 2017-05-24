using System;

public class PassedOrFailed
{
    public static void Main()
    {
        //Input
        double grade = double.Parse(Console.ReadLine());

        //Output
        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}