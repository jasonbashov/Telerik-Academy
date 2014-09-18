using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area.

class CirclePaA
{
    static void Main()
    {
        Console.WriteLine("Enter circle's radius:");
        double r = double.Parse(Console.ReadLine());
        //c=2*pi*r a= pi*r^2
        Console.WriteLine("Circle's perimeter is {0:F2}",(2*3.14*r));
        Console.WriteLine("Circle's area is {0:F2}",(3.14*r*r));
    }
}

