using System;

public class SequenceOfElements
{
    public static void Main()
    {
        int lenghtOfElements = int.Parse(Console.ReadLine());
        int lenghtOfSequence = int.Parse(Console.ReadLine());

        long[] elements = new long[lenghtOfElements];

        elements[0] = 1;

        for (int current = 1; current < elements.Length; current++)
        {
            int start = Math.Max(0, current - lenghtOfSequence);
            int end = current - 1;
            long result = 0;

            for (int prev = start; prev <= end; prev++)
            {
                result += elements[prev];
            }
            elements[current] = result;
        }
        Console.WriteLine(string.Join(" ", elements));
    }
}
