using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingValidation
{
    public static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        var database = new Dictionary<string, string>();

        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int i = 0; i < n; i++)
        {
            string[] currentInput = Console.ReadLine().Split().ToArray();

            string command = currentInput[0];
            string name = currentInput[1];


            switch (command)
            {
                case "register":
                    string licensePlateNumber = currentInput[2];
                    var prefix = currentInput[2].Take(2).ToList();
                    var carNumber = currentInput[2].Skip(2).Take(4).ToArray();
                    var postfix = currentInput[2].Skip(6).Take(2).ToArray();

                    bool arePrefixOrPostfixContainsNumbs = numbers.Contains(prefix[0]) && numbers.Contains(prefix[1]) && numbers.Contains(postfix[0]) && numbers.Contains(postfix[1]);
                    bool isCarnumberContainsOnlyNumbs = numbers.Contains(carNumber[0]) && numbers.Contains(carNumber[1]) && numbers.Contains(carNumber[2]) && numbers.Contains(carNumber[3]);

                    bool arePrefixAndPostfixValid = (int)prefix[0] >= 65 && (int)prefix[0] <= 90 && (int)prefix[1] >= 65 && (int)prefix[1] <= 90 && (int)postfix[0] >= 65 && (int)postfix[0] <= 90 && (int)postfix[1] >= 65 && (int)postfix[1] <= 90;
                    bool isItValidLicense = !arePrefixOrPostfixContainsNumbs && isCarnumberContainsOnlyNumbs;

                    if (isItValidLicense)
                    {
                        if (database.Keys.Contains(currentInput[1]))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {database[currentInput[1]]}");
                            break;
                        }
                        if (!arePrefixAndPostfixValid)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                            break;
                        }
                        if (database.Values.Contains(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                            break;
                        }

                        database[name] = licensePlateNumber;
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                    break;
                case "unregister":

                    if (!database.Keys.Contains(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        break;
                    }

                    database.Remove(name);
                    Console.WriteLine($"user {name} unregistered successfully");
                    break;
            }
        }

        foreach (var user in database)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}
