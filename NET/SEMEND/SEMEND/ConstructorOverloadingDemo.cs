using System;

class Student0
{
    int id;
    string name;
    string course;

    public Student0()
    {
        id = 0;
        name = "Unknown";
        course = "Not Assigned";
    }

    public Student0(int i)
    {
        id = i;
        name = "Not Assigned";
        course = "Not Assigned";
    }

    public Student0(int i, string n)
    {
        id = i;
        name = n;
        course = "Not Assigned";
    }

    public Student0(int i, string n, string c)
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
        Student0 s1 = new Student0();

        Student0 s2 = new Student0(101);

        Student0 s3 = new Student0(102, "Rahul");

        Student0 s4 = new Student0(103, "Rahul", "MSc");

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