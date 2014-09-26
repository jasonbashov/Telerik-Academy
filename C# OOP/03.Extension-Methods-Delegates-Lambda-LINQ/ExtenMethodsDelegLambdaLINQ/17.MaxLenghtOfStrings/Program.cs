//17.Write a program to return the string with maximum length from an array of strings. Use LINQ.
namespace _17.MaxLenghtOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static string maxLengthStr;

        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "az", "titotoitq", "nieVieTe", "tovashtebydenaidalgiqstring", "atozinechak" };

            maxLengthStr = string.Empty;

            var longestString = from str in arrayOfStrings
                               where CompareToMax(str)
                               select str;

            Console.WriteLine(longestString.Last());
        }

        private static bool CompareToMax(string str)
        {
            if (str.Length > maxLengthStr.Length)
            {
                maxLengthStr = str;
                return true;
            }

            return false;
        }
    }
}
