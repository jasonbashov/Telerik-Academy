using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to hexadecimal numbers (directly).


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your binary number: ");
        string binNumber = Console.ReadLine();

        string hex = Convert.ToInt32(binNumber, 2).ToString("X");

        Console.WriteLine(hex);
    }
}

