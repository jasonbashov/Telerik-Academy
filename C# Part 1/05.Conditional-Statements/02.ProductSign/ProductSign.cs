using System;

//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.

class ProductSign
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        double third = double.Parse(Console.ReadLine());

        if (first > 0 && second > 0 && third > 0)//+ + +
        {
            Console.WriteLine("The sign is +");
        }
        else if (first > 0 && second > 0 && third < 0)// + + -
        {
            Console.WriteLine("The sign is -");
        }
        else if (first > 0 && second < 0 && third > 0)//+ - +
        {
            Console.WriteLine("The sign is -");
        }
        else if (first > 0 && second < 0 && third < 0)//+ - -
        {
            Console.WriteLine("The sign is +");
        }
        else if (first < 0 && second > 0 && third > 0)//- + +
        {
            Console.WriteLine("The sign is -");
        }
        else if (first < 0 && second > 0 && third < 0)//- + -
        {
            Console.WriteLine("The sign is +");
        }
        else if (first < 0 && second < 0 && third > 0)//- - +
        {
            Console.WriteLine("The sign is +");
        }
        else if (first < 0 && second < 0 && third < 0)//- - -
        {
            Console.WriteLine("The sign is -");
        }
    }
}

