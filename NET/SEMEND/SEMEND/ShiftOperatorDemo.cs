using System;

class ShiftOperatorDemo
{
    static void Main()
    {
        int num = 8;

        int multiply = num << 1;
        int divide = num >> 1;

        Console.WriteLine("Original Number = " + num);
        Console.WriteLine("After Left Shift (Multiply by 2) = " + multiply);
        Console.WriteLine("After Right Shift (Divide by 2) = " + divide);
    }
}