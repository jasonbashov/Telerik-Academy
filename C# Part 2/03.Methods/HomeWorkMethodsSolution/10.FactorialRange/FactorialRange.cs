using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that 
//multiplies a number represented as array of digits by given integer number. 

class FactorialRange
{
    static BigInteger Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            BigInteger factorial = Factorial(i);
            Console.WriteLine("{0}! = {1}", i, factorial);
        }
    }
}

