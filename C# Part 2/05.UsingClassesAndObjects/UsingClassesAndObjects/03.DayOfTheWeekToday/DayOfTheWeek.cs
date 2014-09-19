using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class DayOfTheWeek
{
    static void Main()
    {
        DateTime dateValue = DateTime.Now;
        Console.WriteLine(dateValue.ToString("dddd"));
    }
}

