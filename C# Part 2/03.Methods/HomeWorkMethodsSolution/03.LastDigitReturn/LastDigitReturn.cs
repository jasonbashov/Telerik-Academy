using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word.
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

class LastDigitReturn
{
    static string ReadLastDigit(int number)
    {
        int ones = number % 10;

        switch (ones)
        {
            case 1: return ("One "); 
            case 2: return ("Two "); 
            case 3: return ("Three ");
            case 4: return ("Four "); 
            case 5: return ("Five "); 
            case 6: return ("Six "); 
            case 7: return ("Seven ");
            case 8: return ("Eigh ");
            case 9: return ("Nine "); 
            default: return "Zero";
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        string word = ReadLastDigit(num);

        Console.WriteLine(word);
    }
}

