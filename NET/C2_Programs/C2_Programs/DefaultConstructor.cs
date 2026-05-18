using System;

class MyClass
{
    public int x;

    public MyClass()
    {
        x = 10;
    }
}

class DefaultConstructor
{
    static void Main()
    {
        MyClass t1 = new MyClass();
        MyClass t2 = new MyClass();

        Console.WriteLine(t1.x + "\n " + t2.x);
    }
}