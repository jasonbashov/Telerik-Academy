using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class GreaterNum
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());

        double max = Math.Max(first, second);

        Console.WriteLine("The greater number is " + max);
    }
}

