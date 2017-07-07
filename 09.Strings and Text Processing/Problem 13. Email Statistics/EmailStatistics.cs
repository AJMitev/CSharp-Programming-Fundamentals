using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EmailStatistics
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string emailValidation = @"^(?<name>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}\.(?:com|bg|org))$";

        var emailsList = new Dictionary<string, List<string>> ();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            var validEmail = Regex.Match(line, emailValidation);
            if (validEmail.Success)
            {
                string username = validEmail.Groups["name"].Value;
                string domain = validEmail.Groups["domain"].Value;

                if (!emailsList.ContainsKey(domain))
                {
                    emailsList.Add(domain, new List<string>());
                }

                if (!emailsList[domain].Contains(username))
                {
                    emailsList[domain].Add(username);
                }
            }
        }

        emailsList = emailsList
            .Distinct()
            .OrderByDescending(u => u.Value.Count)
             .ToDictionary(k => k.Key, v => v.Value);

        foreach (var domain in emailsList)
        {
            Console.WriteLine($"{domain.Key}:");
            foreach (var username in domain.Value)
            {
                Console.WriteLine($"### {username}");
            }
        }
    }
}
