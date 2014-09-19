using System;

//Write an expression that checks for given point (x, y) if it is within 
//the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate X:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate Y:");
        double y = double.Parse(Console.ReadLine());
        bool check = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (3 * 3));// a^2 + b^2 = c^2 and -1 because of the circle coordinates
        if (check)
        {
            Console.WriteLine("The point is within the circle");
        }
        else
        {
            Console.WriteLine("The point is NOT within the circle");
        }
        double rectangleHeight = 2;
        double rectangleWidth = 6;
        double topY = 0 + (rectangleHeight / 2);
        double rightX = 0 + (rectangleWidth / 2);
        double bottomY = 0 - (rectangleHeight / 2);
        double leftX = 0 - (rectangleWidth / 2);
        double rectanglePointX = x - (-1); // = x + 1
        double rectanglePointY = y - 1;
        if ((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX))
        {
            Console.WriteLine("The given points is within the rectangle.");
        }
        else
        {
            Console.WriteLine("The given points is NOT within the rectangle.");
        }
    }
}

