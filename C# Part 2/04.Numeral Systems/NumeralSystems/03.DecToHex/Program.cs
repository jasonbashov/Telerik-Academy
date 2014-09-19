using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());

        string hexValue = number.ToString("X");

        Console.WriteLine(hexValue);
    }
}

