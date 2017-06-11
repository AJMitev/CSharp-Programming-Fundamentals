using System;
using System.Linq;

public class SafeManipulation
{
    public static void Main()
    {
        //Input
        string[] arrayOfWords = Console.ReadLine().Split(' ');

        //Logic
        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            bool isEnded = false;

            switch (command[0])
            {
                case "END": isEnded = true; break;
                case "Reverse": Array.Reverse(arrayOfWords); break;
                case "Distinct": arrayOfWords = arrayOfWords.Distinct().ToArray(); break;
                case "Replace":
                    if (int.Parse(command[1]) > arrayOfWords.Length - 1 ||  int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }
                    else
                    {
                        arrayOfWords[int.Parse(command[1])] = command[2];
                    }
                    break;
                default: Console.WriteLine("Invalid input!"); break;
            }

            if (isEnded)
            {
                break;
            }
        }

        //Output
        Console.WriteLine(string.Join(", ", arrayOfWords));
    }
}