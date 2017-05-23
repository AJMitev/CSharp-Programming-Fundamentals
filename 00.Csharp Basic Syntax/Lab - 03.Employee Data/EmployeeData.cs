using System;

public class EmployeeData
{
    public static void Main()
    {
        //Input
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int employeeId = int.Parse(Console.ReadLine());
        decimal salary = decimal.Parse(Console.ReadLine());

        //Output
        Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {employeeId:D8}\nSalary: {salary:f2}");
    }
}

