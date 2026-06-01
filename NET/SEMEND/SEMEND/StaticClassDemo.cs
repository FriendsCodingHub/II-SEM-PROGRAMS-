using System;

static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class StaticClassDemo
{
    static void Main()
    {
        Console.WriteLine("Addition: " + Calculator.Add(10, 20));

        Console.WriteLine("Multiplication: " + Calculator.Multiply(5, 4));
    }
}