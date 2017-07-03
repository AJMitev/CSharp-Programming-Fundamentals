using System;
using System.Collections.Generic;
using System.Linq;

public class KaraokeAwards
{
    public static void Main()
    {
        var paritcipiants = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var avaliableSongs = Console.ReadLine().Split(',').ToList(); ;

        for (int i = 1; i < avaliableSongs.Count; i++)
        {
            avaliableSongs[i] = avaliableSongs[i].Trim();
        }
        string input = Console.ReadLine();

        var awardedPlayers = new Dictionary<string, List<string>>();
        foreach (var player in paritcipiants)
        {
            awardedPlayers[player] = new List<string>();
        }

        while (input != "dawn")
        {
            var currentAwardData = input.Split(',').ToList();
            string winner = currentAwardData[0];
            string song = currentAwardData[1].Trim();
            string awardWon = currentAwardData[2].Trim();

            if (paritcipiants.Contains(winner) && avaliableSongs.Contains(song))
            {
             
                awardedPlayers[winner].Add(awardWon);
            }

            input = Console.ReadLine();
        }

        if (!awardedPlayers.Count.Equals(0))
        {
            foreach (var person in awardedPlayers.OrderByDescending(p => p.Value.Distinct().Count()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value.Distinct().Count()} awards");
                foreach (var award in person.Value.Distinct().OrderBy(a=>a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }
    }
}