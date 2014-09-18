using System;

//Write an expression that calculates rectangle’s area by given width and height.

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's area: "+(width*height));
    }
}

