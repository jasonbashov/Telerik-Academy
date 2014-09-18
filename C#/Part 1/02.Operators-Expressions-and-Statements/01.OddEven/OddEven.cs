using System;

//Write an expression that checks if given integer is odd or even.

class OddEven
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Integer is even");
        }
        else
        {
            Console.WriteLine("Integer is odd");
        }
    }
}

