using System;

class JaggedArrayDemo
{
    static void Main()
    {
        int[][] arr = new int[3][];

        arr[0] = new int[5];
        arr[1] = new int[8];
        arr[2] = new int[4];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter " + arr[i].Length + " elements for Array " + (i + 1) + ":");

            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array " + (i + 1) + ": ");

            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}