using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade => Grades.Average();

}
public class PrintStidentAverageGrades
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] currentStudent = Console.ReadLine().Split().ToArray();

            var newStudent = new Student
            {
                Name = currentStudent[0],
                Grades = new List<double>()
            };

            for (int gradeIndex = 1; gradeIndex < currentStudent.Length; gradeIndex++)
            {
                double currentGrade = double.Parse(currentStudent[gradeIndex]);
                newStudent.Grades.Add(currentGrade);
            }

            students.Add(newStudent);
        }

        List<Student> notableStudents = students.OrderBy(student => student.Name).ThenByDescending(student => student.AverageGrade).ToList();

        foreach (var student in notableStudents)
        {
            if (student.AverageGrade >= 5)
            {
                Console.WriteLine("{0:f2} -> {1:f2}", student.Name, student.AverageGrade);
            }

        }
    }
}
