using System;

class TypeCastingDemo
{
    static void Main()
    {
        int a = 100;
        double b = a;
        Console.WriteLine("Implicit Int to Double: " + b);

        char ch = 'A';
        int ascii = ch;
        Console.WriteLine("Implicit Char to Int: " + ascii);

        int num = 5000;
        long l = num;
        Console.WriteLine("Implicit Int to Long: " + l);

        float f = 12.75f;
        double d = f;
        Console.WriteLine("Implicit Float to Double: " + d);

        double x = 9.7;
        int y = (int)x;
        Console.WriteLine("Explicit Double to Int: " + y);

        long big = 123456789;
        int small = (int)big;
        Console.WriteLine("Explicit Long to Int: " + small);

        double p = 65.99;
        int q = (int)p;
        Console.WriteLine("Explicit Double to Int: " + q);

        int val = 130;
        byte bt = (byte)val;
        Console.WriteLine("Explicit Int to Byte: " + bt);
    }
}