using System;

class SumSomeNumbers
{
    static void Main()
    {
        //Input
        string[] items = Console.ReadLine().Split(' ');

        //Logic
        int[] arr = new int[items.Length];
        int cntr = 0;

        for (int i = 0; i < items.Length; i++)
        {
            arr[i] = int.Parse(items[i]);
        }

        for (int a = 0; a < arr.Length - 1; a++)
        {

            for (int b = a + 1; b < arr.Length; b++)
            {

                for (int c = 0; c < arr.Length; c++)
                {

                    if (arr[a] + arr[b] == arr[c])
                    {
                        cntr++;   //Counting if there is a correct sum value
                        Console.WriteLine(arr[a] + " + " + arr[b] + " == " + arr[c]);
                        break;

                    }
                }
            }
        }
        if (cntr == 0) //Printing error if there is no correct sum value
        {
            Console.WriteLine("No");
        }
    }
}