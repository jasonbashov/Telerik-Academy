using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

//I think this program will only work correctly if your computer's culture is Bulgarian (because of the holidays)

class WorkDays
{
    static string[] holidays = { "1.1.2014 г.", "2.1.2014 г.", "3.3.2014 г.", "1.5.2014 г.", "6.5.2014 г.", "24.5.2014 г.", "6.9.2014 г.", "1.11.2014 г.", "24.12.2014 г.", "25.12.2014 г.", "26.12.2014 г." };
    static DateTime[] holiday = new DateTime[holidays.Length];

    static bool CheckNumber(int number, int start, int end)
    {
        if (number > start)
        {
            if (number < end)
            {
                return true;
            }
            return false;
        }
        return false;
    }

    static string EnterDate()
    {
        int month;
        int day;
        string date;

        Console.WriteLine("Enter date:");

        Console.WriteLine("Year:");
        int year = int.Parse(Console.ReadLine());


        do
        {
            Console.WriteLine("Month:");
            month = int.Parse(Console.ReadLine());
        }
        while (!CheckNumber(month, 0, 13));

        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)//months with 31 days
        {
            do
            {
                Console.WriteLine("Day:");
                day = int.Parse(Console.ReadLine());
            }
            while (!CheckNumber(day, 0, 32));
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            do
            {
                Console.WriteLine("Day:");
                day = int.Parse(Console.ReadLine());

            }
            while (!CheckNumber(day, 0, 31));
        }
        else
        {
            if (DateTime.IsLeapYear(year))
            {
                do
                {
                    Console.WriteLine("Day:");
                    day = int.Parse(Console.ReadLine());

                }
                while (!CheckNumber(day, 0, 30));
            }
            else
            {
                do
                {
                    Console.WriteLine("Day:");
                    day = int.Parse(Console.ReadLine());

                }
                while (!CheckNumber(day, 0, 29));
            }
        }

        date = Convert.ToString(year + "-" + month + "-" + day);
        return date;
    }

    static bool IsItHoliday(DateTime day)
    {
        string date = day.ToString("d");
        for (int i = 0; i < holidays.Length; i++)
        {
            if (date == holidays[i])
            {
                return true;
            }
        }
        return false;
    }

    static bool IsItWeekend(DateTime day)
    {
        string dayOfWeek = Convert.ToString(day.DayOfWeek);

        switch (dayOfWeek)
        {
            case "Saturday":
                return true;
            case "Sunday":
                return true;
            default:
                return false;
        }
    }

    static int HowManyWorkDays(DateTime myDate, int difference)
    {
        int workDays = 0;

        for (int i = 0; i < difference; i++)
        {
            if (!IsItWeekend(myDate))
            {
                if (!IsItHoliday(myDate))
                {
                    workDays++;
                }
            }
            myDate = myDate.AddDays(1.0);
        }

        return workDays;
    }
    static void Main()
    {
        int workDays = 0;

        for (int i = 0; i < holiday.Length; i++)
        {
            holiday[i] = DateTime.Parse(holidays[i]);
        }

        string dateEntered = EnterDate();

        //here we find the difference in days between the date entered and the current day
        DateTime dateValueToday = DateTime.Today;
        DateTime myDate = DateTime.Parse(dateEntered);


        System.TimeSpan diff1 = myDate - dateValueToday;
        int difference = (int)diff1.TotalDays;

        workDays = HowManyWorkDays(dateValueToday, difference);

        Console.WriteLine("There are {0} work days!", workDays);

        if (workDays == 0)
        {
            Console.WriteLine("There are no work days in the past and today");
        }
    }
}

