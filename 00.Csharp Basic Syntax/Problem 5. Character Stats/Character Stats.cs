using System;

public class CharacterStats
{
    public static void Main()
    {
        //Input
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maximumHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maximumEnergy = int.Parse(Console.ReadLine());

        //Logic
        int countLowHealth = maximumHealth - currentHealth;
        int countLowEnergy = maximumEnergy - currentEnergy;

        //Output
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: "+ "|" + new string('|',currentHealth) + new string('.',countLowHealth) + "|");
        Console.WriteLine($"Energy: " + "|" + new string('|', currentEnergy) + new string('.', countLowEnergy) + "|");
    }
}