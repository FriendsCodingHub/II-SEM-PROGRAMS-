using System;

class MethodOverloadingDemo
{
    int Sum(int a, int b)
    {
        return a + b;
    }

    int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    double Sum(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        MethodOverloadingDemo obj = new MethodOverloadingDemo();

        Console.WriteLine("Sum of Two Integers = " + obj.Sum(10, 20));

        Console.WriteLine("Sum of Three Integers = " + obj.Sum(10, 20, 30));

        Console.WriteLine("Sum of Two Doubles = " + obj.Sum(10.5, 20.5));
    }
}