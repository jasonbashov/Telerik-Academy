using System;

//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in Internet).

class EuclideanAlgorithm
{
    static void Main()
    {
        double remainder = 0;
        double a = 0;
        double gCD = 0;

        Console.WriteLine("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        if (first < second)//changing the values of first and second if the first number is smaller than the second
        {
            a = second;
            second = first;
            first = a;
        }

        do
        {
            remainder = first % second;
            gCD = second;
            first = second;
            second = remainder;
        } while (remainder != 0);
	
        Console.WriteLine("The greatest common divider is: {0:F4}",gCD);
    }
}

