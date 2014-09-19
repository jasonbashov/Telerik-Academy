using System;

//Write a program that finds the biggest of three integers using nested if statements.

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter the first  integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third integer:");
        int third = int.Parse(Console.ReadLine());

        if (first >= second && first >= third)
        {
            Console.WriteLine("The biggest integer is " + first);
        }
        else
        {
            if (second >= first && second >= third)
            {
                Console.WriteLine("The biggest integer is " + second);
            }
            else
            {
                Console.WriteLine("The biggest integer is " + third);
            }
        }
    }
}

