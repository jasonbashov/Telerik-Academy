using System;
using System.Numerics;

//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: (2n)!/((n+1)!*n!) for n>=0
//Write a program to calculate the Nth Catalan number by given N.

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                numerator *= i;
            }

            for (int i = 1; i <= (n + 1); i++)
            {
                denomerator1 *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                denomerator2 *= i;
            }
            result = numerator / (denomerator1 * denomerator2);
            Console.WriteLine("The {0}th Catalan number is {1}", n, result);
        }
        else
        {
            Console.WriteLine("N must be >= 0");
        }
    }
}

