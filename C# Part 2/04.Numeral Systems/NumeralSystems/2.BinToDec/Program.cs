using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your binary number:");
        long binNumber = long.Parse(Console.ReadLine());
    
        string s = Convert.ToString(binNumber);
    
        var dec = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // we start with the least significant digit, and work our way to the left
            if (s[s.Length - i - 1] == '0') continue;
            dec += (int)Math.Pow(2, i);
        }
        Console.WriteLine(dec);
    }
}
