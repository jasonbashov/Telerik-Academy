using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints
//the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
//to do: show the day of the week

namespace _16.DateAndTimeAfter
{
    class DateAndTimeAfter
    {
        static void Main()
        {
            Console.WriteLine("Enter your date in the given format (dd.mm.yyyy hh:mm:ss):");
            string dateTime = Console.ReadLine();
            //split the string dateTime into different integers of dd;mm;yy;hh...
            string[] elements = dateTime.Split('.', ' ', ':');

            DateTime yourDateTime = new DateTime(int.Parse(elements[2]),int.Parse(elements[1]), int.Parse(elements[0]),int.Parse(elements[3]),int.Parse(elements[4]), int.Parse(elements[5]));

            DateTime newdate = yourDateTime.AddHours(6).AddMinutes(30);

            Console.WriteLine(newdate);

            string day = newdate.DayOfWeek.ToString();

            Console.WriteLine(day);

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Понеделник");
                    break;
                case "Tuesday":
                    Console.WriteLine("Вторник");
                    break;
                case "Wednesday":
                    Console.WriteLine("Сряда");
                    break;
                case "Thursday":
                    Console.WriteLine("Четвъртък");
                    break;
                case "Friday":
                    Console.WriteLine("Петък");
                    break;
                case "Saturday":
                    Console.WriteLine("Събота");
                    break;
                case "Sunday":
                    Console.WriteLine("Неделя");
                    break;
                default:
                    Console.WriteLine("Error: cultures difference");
                    break;
            }
        }
    }
}
