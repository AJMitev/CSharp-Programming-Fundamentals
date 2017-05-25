using System;

public class Counter
{
    public static void Main()
    {
        //Input
        int number = int.Parse(Console.ReadLine());

        //Logic
        int totalCalories = 0;

        for (int i = 0; i < number; i++)
        {
            string currentProduct = Console.ReadLine().ToLower();

            switch (currentProduct.ToLower())
            {
                case "cheese": totalCalories += 500; break;
                case "tomato sauce": totalCalories += 150; break;
                case "salami": totalCalories += 600; break;
                case "pepper": totalCalories += 50; break;
                default: break;
            }
        }

        //Output
        Console.WriteLine($"Total calories: {totalCalories}");
    }
}