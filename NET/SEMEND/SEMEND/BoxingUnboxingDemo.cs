using System;

class BoxingUnboxingDemo
{
    static void Main()
    {
        int num = 100;

        object obj = num;
        Console.WriteLine("Boxing: " + obj);

        int value = (int)obj;
        Console.WriteLine("Unboxing: " + value);
    }
}