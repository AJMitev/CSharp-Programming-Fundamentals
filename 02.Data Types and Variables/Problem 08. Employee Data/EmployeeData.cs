using System;

public class EmployeeData
{
    public static void Main()
    {
        //Input
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalNumber = long.Parse(Console.ReadLine());
        long employeeNumber = long.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalNumber}\n" +
            $"Unique Employee number: {employeeNumber}");
    }
}