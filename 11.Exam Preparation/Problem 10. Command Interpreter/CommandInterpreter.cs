using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    public static void Main()
    {
        var stringArr = Console.ReadLine().Split().ToList();

        while (true)
        {
            string command = Console.ReadLine();

            int count = 0;
            int startIndex = 0;
            bool isInvalid = startIndex < 0 || startIndex > int.MaxValue || count < 0 || count > int.MaxValue || startIndex > stringArr.Count - 1 || startIndex + count > stringArr.Count;

            if (command == "end")
            {
                break;
            }

            string[] currentCommand = command.Split().ToArray();
            string action = currentCommand[0];

            switch (action)
            {
                case "reverse":

                    startIndex = int.Parse(currentCommand[2]);
                    count = int.Parse(currentCommand[4]);

                    if (isInvalid)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    stringArr = StringReverse(startIndex, count, stringArr);
                    break;
                case "sort":
                    startIndex = int.Parse(currentCommand[2]);
                    count = int.Parse(currentCommand[4]);

                    if (isInvalid)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    stringArr = StringSort(startIndex, count, stringArr);
                    break;
                case "rollLeft":

                    count = int.Parse(currentCommand[1]);

                    if (count < 0 || count > int.MaxValue)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    stringArr = RollLeft(count, stringArr);
                    break;
                case "rollRight":

                    count = int.Parse(currentCommand[1]);

                    if (count < 0 || count > int.MaxValue)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    stringArr = RollRight(count, stringArr);
                    break;
                default:
                    Console.WriteLine("Invalid input parameters.");
                    break;
            }
        }

        //Printing the result
        Console.WriteLine("[" + string.Join((", "), stringArr) + "]");
    }

    private static List<string> RollLeft(int count, List<string> stringArr)
    {

        count = count % stringArr.Count;

        for (int i = 0; i < count; i++)
        {
            string currentString = stringArr[0];
            stringArr.RemoveAt(0);
            stringArr.Insert(stringArr.Count, currentString);
        }

        return stringArr;
    }

    private static List<string> RollRight(int count, List<string> stringArr)
    {
        int itemIndex = stringArr.Count - 1;
        count = count % stringArr.Count;
        for (int i = 0; i < count; i++)
        {
            string currentString = stringArr[itemIndex];
            stringArr.RemoveAt(itemIndex);
            stringArr.Insert(0, currentString);
        }

        return stringArr;
    }

    private static List<string> StringSort(int startIndex, int count, List<string> stringArr)
    {

        string[] portionToSoft = new string[count];
        int indexCntr = 0;

        for (int i = startIndex; i < startIndex + count; i++)
        {
            portionToSoft[indexCntr] = stringArr[i];
            indexCntr++;
        }
        var sorted = portionToSoft.OrderBy(n => n).ToArray();
        stringArr.RemoveRange(startIndex, count);

        for (int i = 0; i < sorted.Length; i++)
        {
            stringArr.Insert(startIndex + i, sorted[i]);
        }

        return stringArr;
    }

    private static List<string> StringReverse(int startIndex, int count, List<string> stringArr)
    {
        string[] stringsToReverse = new string[count];
        int indexCntr = 0;

        for (int i = startIndex; i < startIndex + count; i++)
        {
            stringsToReverse[indexCntr] = stringArr[i];
            indexCntr++;
        }
        var reversed = stringsToReverse.Reverse().ToArray();
        stringArr.RemoveRange(startIndex, count);

        for (int i = 0; i < reversed.Length; i++)
        {
            stringArr.Insert(startIndex + i, reversed[i]);
        }

        return stringArr;
    }
}
