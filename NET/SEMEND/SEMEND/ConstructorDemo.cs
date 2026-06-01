using System;

class ConstructorDemo
{
    int num;

    // Simple Constructor
    public ConstructorDemo()
    {
        num = 100;
        Console.WriteLine("Simple Constructor Value: " + num);
    }

    // Parameterized Constructor
    public ConstructorDemo(int n)
    {
        num = n;
        Console.WriteLine("Parameterized Constructor Value: " + num);
    }

    static void Main()
    {
        ConstructorDemo obj1 = new ConstructorDemo();

        ConstructorDemo obj2 = new ConstructorDemo(500);
    }
}