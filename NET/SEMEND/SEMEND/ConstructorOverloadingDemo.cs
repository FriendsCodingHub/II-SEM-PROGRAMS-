using System;

class Student
{
    int id;
    string name;
    string course;

    public Student()
    {
        id = 0;
        name = "Unknown";
        course = "Not Assigned";
    }

    public Student(int i)
    {
        id = i;
        name = "Not Assigned";
        course = "Not Assigned";
    }

    public Student(int i, string n)
    {
        id = i;
        name = n;
        course = "Not Assigned";
    }

    public Student(int i, string n, string c)
    {
        id = i;
        name = n;
        course = c;
    }

    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Course: " + course);
        Console.WriteLine();
    }
}

class ConstructorOverloadingDemo
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        Student s2 = new Student(101);

        Student s3 = new Student(102, "Rahul");

        Student s4 = new Student(103, "Rahul", "MSc");

        Console.WriteLine("Default Constructor:");
        s1.Display();

        Console.WriteLine("One Parameter Constructor:");
        s2.Display();

        Console.WriteLine("Two Parameter Constructor:");
        s3.Display();

        Console.WriteLine("Three Parameter Constructor:");
        s4.Display();
    }
}