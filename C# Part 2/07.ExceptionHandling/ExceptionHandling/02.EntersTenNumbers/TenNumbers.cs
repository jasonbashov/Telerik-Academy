using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.EntersTenNumbers
{
    class TenNumbers
    {
        public static int ReadNumber(int start, int end)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    Console.WriteLine("Invalid number!");
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return number;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
                throw new FormatException();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
                throw new OverflowException();
            }
        }
        static void Main(string[] args)
        {
            int numberStart = 1;
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ReadNumber(numberStart, 100);
                numberStart = numbers[i];
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("a1: " + number);
            }
        }
    }
}
