using System;

class Student1
{
    static int collegeCode;
    int id;
    string name;

    static Student1()
    {
        collegeCode = 1001;
        Console.WriteLine("Static Constructor Called");
    }

    public Student1(int i, string n)
    {
        id = i;
        name = n;
    }

    public static void ShowCollegeCode()
    {
        Console.WriteLine("College Code: " + collegeCode);
        Console.WriteLine();
    }

    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("College Code: " + collegeCode);
        Console.WriteLine();
    }
}

class StaticMethodAndConstructorDemo
{
    static void Main(string[] args)
    {
        Student1.ShowCollegeCode();

        Student1 s1 = new Student1(101, "Rahul");
        Student1 s2 = new Student1(102, "Suraj");

        s1.Display();
        s2.Display();
    }
}