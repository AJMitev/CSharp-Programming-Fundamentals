using System;

public class AlphabetLoops
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int third = 0; third < n; third++)
                {
                    char letterOne = (char)('a' + first);
                    char letterTwo = (char)('a' + second);
                    char letterThree = (char)('a' + third);

                    Console.WriteLine($"{letterOne}{letterTwo}{letterThree}");
                }
            }
        }
    }
}
