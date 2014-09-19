using System;

// Write a program to read your age from the console and print how old you will be after 10 years.

class MyAge
{
    static void Main()
    {
        int a;
        Console.WriteLine("What is your current age: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("After 10 years you will be: {0} ", a + 10);
    }
}

