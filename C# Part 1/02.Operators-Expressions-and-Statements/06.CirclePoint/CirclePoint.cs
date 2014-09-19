using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class CirclePoint
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate X:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate Y:");
        double y = double.Parse(Console.ReadLine());
        if (((x * x) + (y * y) <= (5 * 5)))
        {
            Console.WriteLine("The point is within the circle");
        }
        else
        {
            Console.WriteLine("The point is NOT within the circle");
        }
    }
}

