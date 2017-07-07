using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        var demonsList = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
        string namePattern = @"[^0-9+\-*\/\.]";
        string damagePattern = @"[+-]?\d+(?:\.?\d+)?";

        
        var deamonsBook = new List<Demon>();

        foreach (var demonName in demonsList)
        {
 
            int currentDemonHealt = CalculatingHealth(demonName, namePattern);
            double currentDemonDamage = CalculatingDamage(demonName, damagePattern);

            Demon newDemon = new Demon
            {
                Name = demonName,
                Health = currentDemonHealt,
                Damage = currentDemonDamage
            };

            deamonsBook.Add(newDemon);
        }

        foreach (Demon demon in deamonsBook.OrderBy(n=>n.Name))
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }
    }

    private static double CalculatingDamage(string demonName, string damagePattern)
    {
        var damageMatches = Regex.Matches(demonName, damagePattern);
        var demonDamage = 0.0;
        var modifiers = demonName.Where(a => a == '*' || a == '/').ToArray();

        foreach (Match damage in damageMatches)
        {
            double currDMG = double.Parse(damage.ToString());
            demonDamage += currDMG;
        }

        foreach (var action in modifiers)
        {
            switch (action)
            {
               case '*':
                    demonDamage *= 2;
                    break;
                case '/':
                    demonDamage /= 2;
                    break;
            }

        }
            return demonDamage;
    }

    private static int CalculatingHealth(string demonName, string namePattern)
    {
        var nameMatches = Regex.Matches(demonName, namePattern);
        var deamonHealt = 0;

        foreach (Match match in nameMatches)
        {
            char curretnLetter = char.Parse(match.ToString());
            deamonHealt += (int)curretnLetter;
        }

        return deamonHealt;
    }
}

public class Demon
{
    public string  Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}

