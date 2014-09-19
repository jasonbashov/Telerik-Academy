using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.


namespace _19.ExtractingDatesFromText
{
    class ExtractingDates
    {
        static void Main(string[] args)
        {
            string text = "On today's date: 01.01.2001 is signed the new contract of the player expering on 24.10.2004";
            var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
            foreach (Match m in regex.Matches(text))
            {
                DateTime dt;
                if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
                    Console.WriteLine(dt.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
