
using System;

delegate void Calculate(int a, int b);

class Calculator
{
    
    public void Add(int x, int y)
    {
        Console.WriteLine("Addition = " + (x + y));
    }

    public void Subtract(int x, int y)
    {
        Console.WriteLine("Subtraction = " + (x - y));
    }


    public void Multiply(int x, int y)
    {
        Console.WriteLine("Multiplication = " + (x * y));
    }
}

class delegates
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();

        Calculate cal;
 
        cal = c.Add;
        cal(10, 5);
  
        cal = c.Subtract;
        cal(10, 5);

        cal = c.Multiply;
        cal(10, 5);

        Console.ReadLine();
    }
}