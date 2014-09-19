using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


class ShortBinRepresentation
{
    static void Main()
    {
        short shortNumber = 0;
        Console.WriteLine("Enter 16-bit integer(short):");
        string shortNumstr = Console.ReadLine();
        string shortNumberString;

        try
        {
           shortNumber = Int16.Parse(shortNumstr);
        }
        catch (FormatException)
        {
            Console.WriteLine("You have entered an invalid number!");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fit in Int16!");
            return;
        }

        shortNumberString = Convert.ToString(shortNumber, 2).PadLeft(16, '0');

        Console.WriteLine(shortNumberString);
        
    }
}

