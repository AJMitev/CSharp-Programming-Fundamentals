using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        //Input
        var cardPlayers = new Dictionary<string, List<int>>();

        var input = Console.ReadLine();

        while (input != "JOKER")
        {
            var tokens = input.Split(':');

            var name = tokens[0];
            var cards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(CalculateCardValue).ToArray();

            if (!cardPlayers.ContainsKey(name))
            {
                cardPlayers[name] = new List<int>();
            }

            cardPlayers[name].AddRange(cards);

            input = Console.ReadLine();
        }

        foreach (var player in cardPlayers)
        {
            var name = player.Key;
            var cards = player.Value;

            var totalCardSum = cards.Distinct().Sum();
            Console.WriteLine($"{name}: {totalCardSum}");
        }
        Console.WriteLine();
    }
    public static int CalculateCardValue(string card)
    {
        var cardPowers = new Dictionary<string, int>();

        cardPowers["J"] = 11;
        cardPowers["Q"] = 12;
        cardPowers["K"] = 13;
        cardPowers["A"] = 14;

        for (int i = 2; i <=10; i++)
        {
            cardPowers[i.ToString()] = i;

        }

        var cardTypes = new Dictionary<string, int>();
        cardTypes["S"] = 4;
        cardTypes["H"] = 3;
        cardTypes["D"] = 2;
        cardTypes["C"] = 1;

        string power = card.Substring(0, card.Length - 1).ToString();
        string type = card.Substring(card.Length - 1).ToString();

        int cardValue = cardPowers[power] * cardTypes[type];

        return cardValue;
    }
}
