using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Files
{
    public static void Main()
    {
        int numberOfFiles = int.Parse(Console.ReadLine());

        var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < numberOfFiles; i++)
        {
            string[] routeParams = Console.ReadLine().Split('\\');

            string root = routeParams[0];
            string[] fileWithSize = routeParams[routeParams.Length - 1].Split(';');
            string fileName = fileWithSize[0];
            long fileSize = long.Parse(fileWithSize[1]);

            if (!filesByRoot.ContainsKey(root))
            {
                filesByRoot.Add(root, new Dictionary<string, long>());
            }

            if (!filesByRoot[root].ContainsKey(fileName))
            {
                filesByRoot[root].Add(fileName, fileSize);
            }
            else
            {
                filesByRoot[root][fileName] = fileSize;
            }
        }

        string[] queryParams = Console.ReadLine().Split();

        string queryExtension = queryParams[0];
        string queryRoot = queryParams[2];

        if (filesByRoot.ContainsKey(queryRoot))
        {


            Dictionary<string, long> foundFiles = filesByRoot[queryRoot];

            foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (file.Key.EndsWith(queryExtension))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}