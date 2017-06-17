using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook
{
    public static void Main()
    {
        var phonebook = new Dictionary<string, string>();

        string operation = string.Empty;

        do
        {
            string[] input = Console.ReadLine().Split().ToArray();
            if (input[0].Equals("END"))
            {
                break;
            }

            switch (input[0])
            {
                case "A": phonebook[input[1]] = input[2]; break;
                case "S":
                    bool isItContains = phonebook.ContainsKey(input[1]);
                    if (isItContains)
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    break;
            }

        } while (true);

    }
}