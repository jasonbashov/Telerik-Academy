using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class DigitsReverse
{
    static string ReverseDigits(string decimalNumber)
    {
        char[] cArray = decimalNumber.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();

        number = ReverseDigits(number);

        Console.WriteLine(number);
    }
}

