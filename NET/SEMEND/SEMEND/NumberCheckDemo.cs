using System;

class NumberCheckDemo
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive Number");
        else if (num < 0)
            Console.WriteLine("Negative Number");
        else
            Console.WriteLine("Zero");
    }
}