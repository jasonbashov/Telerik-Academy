using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.

class Program
{
    static void Main()
    {
         Console.WriteLine("Enter a number: ");
         int number = int.Parse(Console.ReadLine());

         string binary = Convert.ToString(number, 2);

         Console.WriteLine(binary);

    }
}


