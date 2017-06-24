using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class MentorGroup
{
    public static void Main()
    {
        List<Student> studentList = ReadStudentAttendances();

        ReadComments(studentList);

        for (int i = 0; i < studentList.Count; i++)
        {
            studentList[i].Attendance.Distinct().OrderBy(a => a);
        }

        PrintResult(studentList);

    }

    private static void PrintResult(List<Student> studentList)
    {
        foreach (var student in studentList.OrderBy(student => student.Name))
        {

            Console.WriteLine($"{student.Name}\nComments:");
            foreach (var comment in student.Comments)
            {
                Console.WriteLine($"- {comment}");

            }
            Console.WriteLine($"Dates attended:");
            foreach (var attendance in student.Attendance.OrderBy(d => d))
            {
                Console.WriteLine($"-- {attendance:dd/MM/yyyy}");
            }


        }
    }

    private static void ReadComments(List<Student> studentList)
    {
        string comments = Console.ReadLine();

        while (comments != "end of comments")
        {
            string[] currentComment = comments.Split('-').ToArray();

            string username = currentComment[0];
            string comment = currentComment[1];

            foreach (var student in studentList)
            {
                if (student.Name.Equals(username))
                {
                    student.Comments.Add(comment);
                }

            }



            comments = Console.ReadLine();
        }
    }

    private static List<Student> ReadStudentAttendances()
    {
        string dates = Console.ReadLine();
        List<Student> students = new List<Student>();
        while (dates != "end of dates")
        {
            string[] studentDetails = dates.Split(' ', ',').ToArray();
            string studentsName = studentDetails[0];
            var datesAsString = studentDetails.Skip(1).ToList();
            List<DateTime> studentAttendance = datesAsString.Select(date => DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

            if (students.Select(s => s.Name).Contains(studentsName))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name.Equals(studentsName))
                    {
                        students[i].Attendance.AddRange(studentAttendance);
                       
                    }
                }
            }
            else
            {
                Student currentStudent = new Student
                {
                    Name = studentsName,
                    Attendance = studentAttendance,
                    Comments = new List<string>()
                };

                students.Add(currentStudent);
            }

            dates = Console.ReadLine();
        }

        return students;
    }
}

public class Student
{
    public string Name { get; set; }
    public List<string> Comments { get; set; }
    public List<DateTime> Attendance { get; set; }
}