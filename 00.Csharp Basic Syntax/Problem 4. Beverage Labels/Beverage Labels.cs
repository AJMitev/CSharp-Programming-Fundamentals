using System;

public class BeverageLabels
{
    public static void Main()
    {
        //Input
        string productName = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyContent = int.Parse(Console.ReadLine());
        int sugarContent = int.Parse(Console.ReadLine());

        //Logic
        double currentEnergy = (energyContent * volume)/100.00;
        double currentSugar = (sugarContent * volume)/100.00;

        //Output
        Console.WriteLine($"{volume}ml {productName}:\n{currentEnergy}kcal, {currentSugar}g sugars");
    }
}