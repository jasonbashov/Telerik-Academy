//06.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.DivisibleBy7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DivisibleNumbers
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 9, 12, 21, 147, 200 };

            int[] result = array.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //ling
            int[] result2 = (from num in array where num % 7 == 0 && num % 3 == 0 select num).ToArray();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }      
        }
    }
}
