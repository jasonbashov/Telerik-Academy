using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's side A:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's side B:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's height H:");
        float h = float.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area is {0:F2}",(0.5*h*(a+b)));
    }
}

