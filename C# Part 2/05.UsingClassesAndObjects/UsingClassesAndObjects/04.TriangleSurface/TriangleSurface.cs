using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//  *Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class TriangleSurface
{
    static bool CheckNumber(int number, int start, int end)
    {
        if (number > start)
        {
            if (number < end)
            {
                return true;
            }
            return false;
        }
        return false;
    }

    static double CalculateSurface(double side, double altitude)
    {
        return side * altitude * 0.5;
    }

    static double CalculateSurface(double sideA, double sideB, double sideC)
    {
        double sqrt =  Math.Sqrt((sideA + sideB - sideC) * (sideA - sideB + sideC) * (sideB - sideA + sideC) * (sideA + sideB + sideC));
        double quarter = 1.0 / 4.0;
        return (quarter * sqrt);
    }

    static double CalculateSurface(double sideA, double sideB, int angle)
    {
        //Area = ½ · c · a · sin B

        double area = (1.0 / 2.0) * sideA * sideB * Math.Sin((double)angle);

        return area;
    }

    static void Main()
    {
        int angle;

        Console.WriteLine("Enter side:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter altitude to the side:");
        double altitude = double.Parse(Console.ReadLine());

        double surface = CalculateSurface(side, altitude);
        Console.WriteLine("Surface by given side and altitude: {0}", surface);

        Console.WriteLine("Enter side A:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side C:");
        double c = double.Parse(Console.ReadLine());

        surface = CalculateSurface(a, b, c);
        Console.WriteLine("Surface by given three sides: {0}", surface);

        Console.WriteLine("Enter side A:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        b = double.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Enter angle between them:");
            angle = int.Parse(Console.ReadLine());
        } 
        while (!CheckNumber(angle,0,181));

        surface = CalculateSurface(a, b, angle);

        Console.WriteLine("Surface by given two sides and angle between them: {0}", surface);
        
    }
}

