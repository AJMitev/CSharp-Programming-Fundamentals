using System;

public class Concatenation
{
    public static void Main()
    {
        //Input
        char separator = char.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        int numberOfLines = int.Parse(Console.ReadLine());

        //Logic
        string text = string.Empty;

        for (int i = 1; i <= numberOfLines; i++)
        {
            string currentString = Console.ReadLine();

            if (type.ToLower().Equals("even") && i % 2 == 0)
            {
                text += currentString + separator;
            }
            else if (type.ToLower() == "odd" && i % 2 == 1)
            {
                text += currentString + separator;
            }

        }
        
        //Ouput
        Console.WriteLine(text.Remove(text.Length-1));
    }
}
