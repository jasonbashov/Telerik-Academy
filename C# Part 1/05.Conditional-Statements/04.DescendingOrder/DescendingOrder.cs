using System;

//Sort 3 real values in descending order using nested if statements.

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        double third = double.Parse(Console.ReadLine());

        if (first >= second && first >= third)
        {
            if (second >= third)
            {
                Console.WriteLine(first + " " + second + " " + third);
            }
            else
            {
                Console.WriteLine(first + " " + third + " " + second);
            }
        }

        else if (second >= first && second >= third)
        {
            if (first >= third)
            {
                Console.WriteLine(second + " " + first + " " + third);
            }
            else
            {
                Console.WriteLine(second + " " + third + " " + first);
            }
        }

        else if (third >= first && third >= second)
        {
            if (first >= second)
            {
                Console.WriteLine(third + " " + first + " " + second);
            }
            else
            {
                Console.WriteLine(third + " " + second + " " + first);
            }

        }
    }
}

