using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: (a+b)2)(3. (2(2(2(22))+2

namespace _03.ExpressionCheck
{
    class ExpressionCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter your expression:");
            string expression = Console.ReadLine();

            char[] arrayChars = expression.ToCharArray();

            int counterBracets = 0;

            for (int i = 0; i < arrayChars.Length; i++)
            {
                if (arrayChars[i] == '(')
                {
                    counterBracets++;
                }
                if (arrayChars[i] == ')')
                {
                    counterBracets--;
                }
                if (counterBracets < 0)
                {
                    break;
                }
            }

            if (counterBracets == 0)
            {
                Console.WriteLine("The expression is correct!");
            }
            else
            {
                Console.WriteLine("The expression is INCORRECT!");
            }
        }
    }
}
