using System;
using System.Collections.Generic;
using System.Linq;

public class ChangeList
{
    public static void Main()
    {
        //Input
        var listOfNumbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());

        //Logic
        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0].ToLower().Equals("even"))
            {
                listOfNumbers.RemoveAll(x => x % 2 == 1);
                Console.WriteLine(string.Join(" ", listOfNumbers));
                break;
            }
            else if (command[0].ToLower().Equals("odd"))
            {
                listOfNumbers.RemoveAll(x => x % 2 == 0);
                Console.WriteLine(string.Join(" ", listOfNumbers));
                break;
            }

            switch (command[0])
            {
                case "Delete": listOfNumbers.RemoveAll(x => x.Equals(int.Parse(command[1]))); break;
                case "Insert": listOfNumbers.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
            }
        }
    }
}
