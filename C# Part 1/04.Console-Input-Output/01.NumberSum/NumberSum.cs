using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class NumberSum
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum:"+(a+b+c));
    }
}

