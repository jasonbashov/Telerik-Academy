using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
//the rest of the characters should be filled with '*'. Print the result string into the console.

namespace _06.StringMaxLengthTrim
{
    class StringTrim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string enteredString = Console.ReadLine();

            int difference = enteredString.Length - 20;

            if (difference <= 0)
            {
                Console.WriteLine(enteredString);
            }
            else
            {
               enteredString =  enteredString.Substring(0, 20);
               string stars = "".PadRight(difference, '*');
               Console.WriteLine(enteredString + stars);
            }
        }
    }
}
