using System;

//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

class QuadraticEquation
{
    static void Main()
    {

        double a = 0;
        do
        {
            Console.WriteLine("Enter value for 'a' different from 0:");
            a = double.Parse(Console.ReadLine());

        } while (a == 0);

        Console.WriteLine("Enter value for 'b':");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter values for 'c':");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);
        double discrRoot = Math.Sqrt(discriminant);

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");

        }
        else if (discriminant != 0)
        {
            double x1 = (-b + discrRoot) / (2 * a);
            double x2 = (-b - discrRoot) / (2 * a);
            Console.WriteLine("The roots are x1 = {0} and x2 = {1}", x1, x2);
        }
        else
        {
            Console.WriteLine("The roots x1 = x2 = {0}", (-b / (2 * a)));
        }
    }
}

