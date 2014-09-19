using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

class Program
{
    static string hex2binary(string hexvalue)
    {
        string binaryval = "";
        binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        return binaryval;
    }

    static void Main()
    {
        Console.WriteLine("Enter hexademical number: ");
        string hexidecimal = Console.ReadLine();

        Console.WriteLine(hex2binary(hexidecimal));
    }
}

