using System;

public class HowManyCourses
{
    public static void Main()
    {
        //Input
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        //Logic
        int courses = (int)Math.Ceiling((double)people / capacity);

        //Output
        Console.WriteLine(courses);

    }
}
