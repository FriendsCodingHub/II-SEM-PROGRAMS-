using System;

class StringOp
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "World";
        string s3 = "  Dot Net  ";

        Console.WriteLine("s1 = " + s1);
        Console.WriteLine("s2 = " + s2);
        Console.WriteLine("s3 = " + s3);
        Console.WriteLine();

        Console.WriteLine("s1.Length             : " + s1.Length);
        Console.WriteLine("s1.ToUpper()          : " + s1.ToUpper());
        Console.WriteLine("s1.ToLower()          : " + s1.ToLower());
        Console.WriteLine("String.Concat(s1,s2)  : " + String.Concat(s1, s2));
        Console.WriteLine("s1.Substring(1,3)     : " + s1.Substring(1, 3));
        Console.WriteLine("s1.IndexOf('l')       : " + s1.IndexOf('l'));
        Console.WriteLine("s1.LastIndexOf('l')   : " + s1.LastIndexOf('l'));
        Console.WriteLine("s1.Contains(ell)      : " + s1.Contains("ell"));
        Console.WriteLine("s1.StartsWith(He)     : " + s1.StartsWith("He"));
        Console.WriteLine("s1.EndsWith(lo)       : " + s1.EndsWith("lo"));
        Console.WriteLine("s1.Replace(H,J)       : " + s1.Replace("H", "J"));
        Console.WriteLine("s1.Insert(5, World)   : " + s1.Insert(5, " World"));
        Console.WriteLine("s1.Remove(2,2)        : " + s1.Remove(2, 2));
        Console.WriteLine("String.Compare(s1,s2) : " + String.Compare(s1, s2));
        Console.WriteLine("s1.Equals(s2)         : " + s1.Equals(s2));
        Console.WriteLine("s3.Trim()             : " + s3.Trim());
    }
}