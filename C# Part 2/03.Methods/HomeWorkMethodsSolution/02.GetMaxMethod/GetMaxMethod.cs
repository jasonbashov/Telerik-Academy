using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


class GetMaxMethod
{
    static int GetMax(int first, int second )
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter A:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter B:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter C:");
        int third = int.Parse(Console.ReadLine());
        
        int max = GetMax(first, second);
        max = GetMax(max, third);

        Console.WriteLine("The biggest is: " + max);

    }
}

