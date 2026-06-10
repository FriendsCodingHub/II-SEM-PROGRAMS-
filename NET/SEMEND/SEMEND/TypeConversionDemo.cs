using System;

class TypeConversionDemo
{
    static void Main()
    {
        // Implicit Conversion

        int a = 100;
        double b = a;
        Console.WriteLine("Intial value :" + a);
        Console.WriteLine("Implicit Int to Double: " + b+"\n");

        char ch = 'A';
        int ascii = ch;
        Console.WriteLine("Intial value :" + ch);
        Console.WriteLine("Implicit Char to Int: " + ascii+"\n");

        int num = 5000;
        long l = num;
        Console.WriteLine("Intial value :" + num);
        Console.WriteLine("Implicit Int to Long: " + l + "\n");

        float f = 12.75f;
        double d = f;
        Console.WriteLine("Intial value :" + f);
        Console.WriteLine("Implicit Float to Double: " + d + "\n");

        // Explicit Conversion using Convert Class

        double x = 9.7;
        int y = Convert.ToInt32(x);
        Console.WriteLine("Initial value : " + x);
        Console.WriteLine("Double to Int : " + y + "\n");

        string s1 = "123";
        long l1 = Convert.ToInt64(s1);
        Console.WriteLine("Initial value : " + s1);
        Console.WriteLine("String to Long : " + l1 + "\n");

        int val = 65;
        char c = Convert.ToChar(val);
        Console.WriteLine("Initial value : " + val);
        Console.WriteLine("Int to Char : " + c + "\n");

        string s2 = "123.45";
        double d1 = Convert.ToDouble(s2);
        Console.WriteLine("Initial value : " + s2);
        Console.WriteLine("String to Double : " + d1 + "\n");

        int num1 = 100;
        string str = Convert.ToString(num1);
        Console.WriteLine("Initial value : " + num1);
        Console.WriteLine("Int to String : " + str);
    }
}