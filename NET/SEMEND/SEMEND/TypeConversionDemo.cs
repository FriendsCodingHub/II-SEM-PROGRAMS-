using System;

class TypeConversionDemo
{
    static void Main()
    {
        // Implicit Conversion

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

        // Explicit Conversion using Convert Class

        double x = 9.7;
        int y = Convert.ToInt32(x);
        Console.WriteLine("Explicit Double to Int: " + y);

        long big = 123456789;
        int small = Convert.ToInt32(big);
        Console.WriteLine("Explicit Long to Int: " + small);

        string s = "123";
        int n = Convert.ToInt32(s);
        Console.WriteLine("Explicit String to Int: " + n);

        int val = 65;
        char c = Convert.ToChar(val);
        Console.WriteLine("Explicit Int to Char: " + c);
    }
}