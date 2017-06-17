using System;
using System.Collections.Generic;
using System.Linq;

public class CalcualtingVirusStrenght
{
    public static void Main()
    {
        //Input
        int startedHealth = int.Parse(Console.ReadLine());
        
        //Logic
        var defeatedViruses = new List<string>();
        int health = startedHealth;
        bool isDefeated = false;

        while (true)
        {
            string virusName = Console.ReadLine();
            if (virusName.Equals("end"))
            {
                break;
            }

            int virusStrenght = 0;

            foreach (char c in virusName)
            {
                virusStrenght += (int)c;
            }

            virusStrenght /= 3;

            int timeForDefeat = 0;

            if (!defeatedViruses.Contains(virusName))
            {
                defeatedViruses.Add(virusName);
                timeForDefeat = virusStrenght * virusName.Length;
            }
            else
            {
                timeForDefeat = (virusStrenght * virusName.Length) / 3;
            }

            int defeatMins = timeForDefeat / 60;
            int defeatSecs = timeForDefeat % 60;

            health -= timeForDefeat;

            if (health <= 0)
            {
                Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeForDefeat} seconds");
                Console.WriteLine("Immune System Defeated.");
                isDefeated = true;
                break;
            }
            else
            {
                Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeForDefeat} seconds");
                Console.WriteLine($"{virusName} defeated in {defeatMins}m {defeatSecs}s.");
                Console.WriteLine($"Remaining health: {health}");
            }
            
            health = (int)(health *1.2);

            if (health > startedHealth )
            {
                health = startedHealth;
            }
        }

        if (!isDefeated)
        {
            Console.WriteLine($"Final Health: {health}");
        }
    }
}
