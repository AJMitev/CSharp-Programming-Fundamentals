using System;
using System.Linq;

public class ManipulateArray
{
    public static void Main()
    {
        //Input
        string[] arrayOfWords = Console.ReadLine().Split(' ');
        int manipulationsCount = int.Parse(Console.ReadLine());

        //Logic
        for (int i = 0; i < manipulationsCount; i++)
        {
            string[] command = Console.ReadLine().Split(' ');

            switch (command[0])
            {
                case "Reverse":  Array.Reverse(arrayOfWords);  break;
                case "Distinct": arrayOfWords = arrayOfWords.Distinct().ToArray(); break;
                case "Replace": arrayOfWords[int.Parse(command[1])] = command[2]; break;
            }
         
        }

        Console.WriteLine(string.Join(", ", arrayOfWords));
    }
}