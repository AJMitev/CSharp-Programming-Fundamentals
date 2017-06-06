using System;

public class InstructionSet
{
    public static void Main()
    {

        long result = 0;
        int numberOne = 1;
        int numberTwo = 1;

        do
        {
            string inputData = Console.ReadLine();
            string[] dataArr = inputData.Split(' ');

            if (dataArr[0].ToUpper().Equals("END"))
            {
                Console.WriteLine(result);
                break;
            }

            switch (dataArr[0].ToUpper())
            {
                case "INC": numberOne = int.Parse(dataArr[1]); result = numberOne + 1; break;
                case "DEC": numberOne = int.Parse(dataArr[1]); result = numberOne - 1; break;
                case "ADD": numberOne = int.Parse(dataArr[1]); numberTwo = int.Parse(dataArr[2]); result = numberOne + numberTwo; break;
                case "MLA": numberOne = int.Parse(dataArr[1]); numberTwo = int.Parse(dataArr[2]); result = (long)numberOne * numberTwo; break;
            }

        } while (true);
    }
}