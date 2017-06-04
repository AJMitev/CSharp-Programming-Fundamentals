using System;

public class CalculateMaterials
{
    public static void Main()
    {
        //Input
        string numberOne = Console.ReadLine();
        string numberTwo = Console.ReadLine();

        sbyte sbytePrice = sbyte.MaxValue;
        long intPrice = 0;

        try
        {
             sbytePrice = sbyte.Parse(numberOne);
             intPrice = long.Parse(numberTwo);

        }
        catch (Exception)
        {

             sbytePrice = sbyte.Parse(numberTwo);
             intPrice = long.Parse(numberOne);
        }

        int sbyteMaterials = sbytePrice * 4;
        long intMaterials = intPrice * 10;

        long result = (long)intMaterials + sbyteMaterials;

        //Ouput
        Console.WriteLine(result);
    }
}
