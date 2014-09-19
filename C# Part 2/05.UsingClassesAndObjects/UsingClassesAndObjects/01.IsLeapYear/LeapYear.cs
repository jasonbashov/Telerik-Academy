using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {1} a leap year? {0}", DateTime.IsLeapYear(year), year);

    }
}

