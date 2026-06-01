using System;

class PrefixPostfixDemo
{
    static void Main()
    {
        int a = 10;

        Console.WriteLine("Initial Value = " + a);

        Console.WriteLine("Prefix Increment (++a) = " + (++a));

        Console.WriteLine("Value After Prefix = " + a);

        Console.WriteLine("Postfix Increment (a++) = " + (a++));

        Console.WriteLine("Value After Postfix = " + a);
    }
}