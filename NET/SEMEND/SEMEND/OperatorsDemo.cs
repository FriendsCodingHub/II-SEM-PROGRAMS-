using System;

class OperatorsDemo
{
    public static void Main()
    {
        int a = 10, b = 5;

        Console.WriteLine("Arithmetic:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        Console.WriteLine("\nRelational:");
        Console.WriteLine("a > b = " + (a > b));
        Console.WriteLine("a < b = " + (a < b));
        Console.WriteLine("a == b = " + (a == b));
        Console.WriteLine("a != b = " + (a != b));

        Console.WriteLine("\nLogical:");
        Console.WriteLine("(a > 5 && b < 10) = " + (a > 5 && b < 10));
        Console.WriteLine("(a > 5 || b > 10) = " + (a > 5 || b > 10));
        Console.WriteLine("!(a > b) = " + !(a > b));

        Console.WriteLine("\nAssignment:");
        int x = a;
        x += b;
        Console.WriteLine("x += b = " + x);

        Console.WriteLine("\nIncrement/Decrement:");
        Console.WriteLine("++a = " + (++a));
        Console.WriteLine("b-- = " + (b--));
        Console.WriteLine("After b-- = " + b);

        Console.WriteLine("\nBitwise:");
        Console.WriteLine("a & b = " + (a & b));
        Console.WriteLine("a | b = " + (a | b));
        Console.WriteLine("a ^ b = " + (a ^ b));

        Console.WriteLine("\nConditional:");
        string result = (a > b) ? "a is greater" : "b is greater";
        Console.WriteLine(result);

        Console.WriteLine("\nSpecial:");
        Console.WriteLine("Type of a: " + typeof(int));
        Console.WriteLine("Size of int: " + sizeof(int));
    }
}   