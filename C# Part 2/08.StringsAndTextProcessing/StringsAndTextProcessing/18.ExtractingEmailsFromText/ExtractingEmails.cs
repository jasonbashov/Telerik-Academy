using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractingEmailsFromText
{
    class ExtractingEmails
    {
        public const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
              + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";


        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }

        static void Main()
        {
            string text = "username@abv.bg is the first email and, the second o.ne is seconduser@yahoo.com the third@one is third@gmail.com";
            
            string[] split = text.Split(' ');

            foreach (var str in split)
            {
                if (IsEmail(str))
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
