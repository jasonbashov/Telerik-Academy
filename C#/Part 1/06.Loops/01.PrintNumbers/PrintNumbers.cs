using System;

//Write a program that prints all the numbers from 1 to N.

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

