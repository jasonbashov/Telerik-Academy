using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hex = Console.ReadLine();

        int decValue = Convert.ToInt32(hex, 16);

        Console.WriteLine(decValue);
    }
}

