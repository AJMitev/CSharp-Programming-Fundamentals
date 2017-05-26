using System;

public class ReadingNumbers
{
    public static void Main()
    {
        int counter = 0;
        try
        {
            do
            {
                int integer = int.Parse(Console.ReadLine());
                counter++;

            } while (true);
        }
        catch (Exception)
        {

            Console.WriteLine(counter);
        }
        
    }
}