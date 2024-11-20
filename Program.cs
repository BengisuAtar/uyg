﻿using uyg6;

internal class Program
{
    private static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Ali Yılmaz", "Matematik");

        // Öğrenciler
        Student student1 = new Student("Ayşe Demir", 1);
        Student student2 = new Student("Mehmet Öz", 2);

        // Sınıf
        Class classroom = new Class("1A", teacher);
        classroom.AddStudent(student1);
        classroom.AddStudent(student2);
        classroom.AddCourse("Matematik", "09:00 - 10:00");
        classroom.AddCourse("Fen Bilgisi", "10:15 - 11:15");

        // Ders programını yazdır
        classroom.PrintSchedule();
    }
}

class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }

    public Teacher(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }
}

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

class Class
{
    public string ClassName { get; set; }
    public Teacher ClassTeacher { get; set; }
    private List<Student> Students { get; set; }
    private Dictionary<string, string> Courses { get; set; }

    public Class(string className, Teacher teacher)
    {
        ClassName = className;
        ClassTeacher = teacher;
        Students = new List<Student>();
        Courses = new Dictionary<string, string>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddCourse(string courseName, string time)
    {
        Courses[courseName] = time;
    }

    public void PrintSchedule()
    {
        Console.WriteLine($"Sınıf: {ClassName}");
        Console.WriteLine($"Öğretmen: {ClassTeacher.Name} - {ClassTeacher.Subject}");
        Console.WriteLine("Öğrenciler:");
        foreach (var student in Students)
        {
            Console.WriteLine($"- {student.Name} (ID: {student.Id})");
        }

        Console.WriteLine("Ders Programı:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"- {course.Key}: {course.Value}");
        }
    }
}
}