using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

namespace _11.NumberPrint
{
    class NumberPrint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);   // Decimal
            Console.WriteLine("{0,15:X}", number); // Hexadecimal
            Console.WriteLine("{0,15:P}", number); // Percentage
            Console.WriteLine("{0,15:E}", number); // Scientific notation
        }
    }
}
