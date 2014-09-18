using System;

//Write a program that finds the greatest of given 5 variables.

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter the first variable: ");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second variable: ");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third variable: ");
        double third = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth variable: ");
        double fourth = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fifth variable: ");
        double fifth = double.Parse(Console.ReadLine());

        double greatestNum = first;

        if (first < second)
        {
            greatestNum = second;
        }
        if (greatestNum < third)
        {
            greatestNum = third;
        }
        if (greatestNum < fourth)
        {
            greatestNum = fourth;
        }
        if (greatestNum < fifth)
        {
            greatestNum = fifth;
        }

        Console.WriteLine("The greatest number is: " + greatestNum);
    }
}

