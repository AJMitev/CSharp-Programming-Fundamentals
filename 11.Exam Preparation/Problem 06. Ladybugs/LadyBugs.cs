using System;
using System.Linq;

public class LadyBugs
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] ladybugArr = new long[n];
        long[] indexesWithBug = Console.ReadLine().Split().Select(long.Parse).Where(x => x >= 0 && x < n).ToArray();

        foreach (var index in indexesWithBug)
        {
            ladybugArr[index] = 1;
        }

        string command = Console.ReadLine();
        while (!command.Equals("end"))
        {
            var tokens = command.Split().ToArray();
            long currentBugIndex = long.Parse(tokens[0].ToString());
            string direction = tokens[1];
            long flyLength = long.Parse(tokens[2].ToString());

            if (currentBugIndex < 0 || currentBugIndex >= ladybugArr.Length)
            {
                command = Console.ReadLine();
                continue;
            }

            if (ladybugArr[currentBugIndex] == 0)
            {
                command = Console.ReadLine();
                continue;
            }

            MoveLadybug(ladybugArr, currentBugIndex, flyLength, direction);

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", ladybugArr));
    }

    public static void MoveLadybug(long[] ladybugArr, long currentBugIndex, long flyLength, string direction)
    {
        ladybugArr[currentBugIndex] = 0;
        var leaveArrayOrFindPlace = false;

        while (!leaveArrayOrFindPlace)
        {
            switch (direction)
            {
                case "left":
                    currentBugIndex -= flyLength;
                    break;
                case "right":
                    currentBugIndex += flyLength;
                    break;
            }

            if(currentBugIndex < 0 || currentBugIndex >= ladybugArr.Length)
            {
                leaveArrayOrFindPlace = true;
                continue;
            }

            if (ladybugArr[currentBugIndex] == 1)
            {
                continue;
            }

            if (ladybugArr[currentBugIndex] == 0)
            {
                ladybugArr[currentBugIndex] = 1;
                leaveArrayOrFindPlace = true;
                continue;
            }
        }
    }
}
