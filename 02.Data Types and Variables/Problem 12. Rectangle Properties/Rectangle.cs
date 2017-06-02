using System;

class Rectangle
{
    static void Main()
    {
        //Input
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        //Logic
        double perimeter = (width + height) * 2;
        double area = width * height;
        double diagonal = Math.Sqrt((width* width) + (height*height));

        //Output
        Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");

    }
}