using System;
using System.Collections.Generic;
using System.Linq;

public class MagicExchangeableWords
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();

        bool result = AreExchangeable(input);
        Console.WriteLine(result.ToString().ToLower());

    }

    private static bool AreExchangeable(string[] input)
    {
        bool areTheyExchangeable = true;
        var assignedChars = new Dictionary<char, char>();

        string stringOne = input[0];
        string stringTwo = input[1];
        int minLenght = Math.Min(stringOne.Length, stringTwo.Length);

        for (int i = 0; i < minLenght; i++)
        {
            if (!assignedChars.ContainsKey(stringOne[i]))
            {
                if (!assignedChars.ContainsValue(stringTwo[i]))
                {
                    assignedChars[stringOne[i]] = stringTwo[i];
                }
                else
                {
                    areTheyExchangeable = false;
                    break;
                }
            }
            else
            {
                if (!assignedChars[stringOne[i]].Equals(stringTwo[i]))
                {
                    areTheyExchangeable = false;
                    break;
                }
            }
        }

        string remaining = string.Empty;

        if (stringOne.Length > stringTwo.Length)
        {
            remaining = stringOne.Substring(minLenght);
        }
        else
        {
            remaining = stringTwo.Substring(minLenght);
        }

        foreach (char letter in remaining)
        {
            if (!assignedChars.ContainsValue(letter) && !assignedChars.ContainsKey(letter))
            {
                areTheyExchangeable = false;
            }
        }

        return areTheyExchangeable;
    }
}