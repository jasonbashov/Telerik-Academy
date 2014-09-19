using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
        //Enter the first date: 27.02.2006
        //Enter the second date: 3.03.2004
        //Distance: 4 days

namespace _16.DaysDifference
{
    class DaysDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter the first date in format (dd.mm.yyyy):");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter the second date:");
            string secondDate = Console.ReadLine();

            string[] dates = firstDate.Split('.');
            int day = int.Parse(dates[0]);
            int month = int.Parse(dates[1]);
            DateTime first = new DateTime(1,month,day);

            string[] secondDates = secondDate.Split('.');
            day = int.Parse(secondDates[0]);
            month = int.Parse(secondDates[1]);
            DateTime second = new DateTime(1, month, day);

            Console.WriteLine("Difference is:{0} days",first - second);
        }
    }
}
