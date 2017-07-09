using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ArrayManipulator
{
    public static void Main()
    {
        var numberArray = Console.ReadLine().Split().Select(int.Parse).ToList();

        string line = Console.ReadLine();

        while (line != "end")
        {

            var command = line.Split();

            string action = command[0];
            switch (action)
            {
                case "exchange":
                    int index = int.Parse(command[1]);
                    index = (index % numberArray.Count) + 1;

                    if (index >= 0 && index <= numberArray.Count)
                    {
                        ArrayExchange(numberArray, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;
                case "max":
                    string maxType = command[1];
                    int maxIndex = GetMaxIndex(numberArray, maxType);
                    if (maxIndex.Equals(-1))
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "min":
                    string minType = command[1];
                    int minIndex = GetMinIndex(numberArray, minType);
                    if (minIndex.Equals(-1))
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "first":
                    FindFirst(numberArray, command);
                    break;
                case "last":
                    break;
                default:
                    break;
            }


            line = Console.ReadLine();
        }
    }

    private static void FindFirst(List<int> numberArray, string[] command)
    {
        int countFirst = int.Parse(command[1]);
        int[] firsOfType = new int[countFirst];

        for (int i = 0; i < countFirst; i++)
        {

        }
        var currentNum = numberArray.FindIndex(0,countFirst,x => x % 2 == 2);
    }

    private static int GetMinIndex(List<int> numberArray, string type)
    {
        int currentOperator = 0;
        if (type.Equals("even"))
        {
            currentOperator = 2;
        }
        else if (type.Equals("odd"))
        {
            currentOperator = 1;
        }

        int minIndex = -1;
        int minNumber = 0;

        for (int i = 0; i < numberArray.Count; i++)
        {
            int currentNumber = numberArray[i];

            if (i % 2 == currentOperator && minNumber < currentNumber)
            {
                minIndex = i;
            }
        }

        return minIndex;
    }
    private static int GetMaxIndex(List<int> numberArray, string type)
    {
        int currentOperator = 0;
        if (type.Equals("even"))
        {
            currentOperator = 2;
        }
        else if (type.Equals("odd"))
        {
            currentOperator = 1;
        }

        int maxIndex = -1;
        int maxNumber = 0;

        for (int i = 0; i < numberArray.Count; i++)
        {
            int currentNumber = numberArray[i];

            if (i % 2 == currentOperator && maxNumber > currentNumber)
            {
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    private static void ArrayExchange(List<int> numberArray, int index)
    {

        for (int i = 0; i < index; i++)
        {
            numberArray.Insert(numberArray.Count, numberArray[0]);
            numberArray.Remove(numberArray[0]);
        }
    }
}
