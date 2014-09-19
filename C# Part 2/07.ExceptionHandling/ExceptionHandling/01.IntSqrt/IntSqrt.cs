using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

namespace _01.IntSqrt
{
    class IntSqrt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number:");
                uint number = uint.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt((double)(number)));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
