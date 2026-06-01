using System;

class Student2 : IResult
{
    int marks1, marks2, total;
    double average;


    public void GetMarks()
    {
        marks1 = 85;
        marks2 = 90;

        Console.WriteLine("Marks in Subject 1 : " + marks1);
        Console.WriteLine("Marks in Subject 2 : " + marks2);
    }


    public void CalculateResult()
    {
        total = marks1 + marks2;
        average = total / 2.0;

        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Average : " + average);

        if (average >= 50)
        {
            Console.WriteLine("Result : Pass");
        }
        else
        {
            Console.WriteLine("Result : Fail");
        }
    }
}