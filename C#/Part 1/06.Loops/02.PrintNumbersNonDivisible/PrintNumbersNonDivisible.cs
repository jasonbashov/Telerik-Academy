using System;

//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

class PrintNumbersNonDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ((i % (7 * 3) != 0))
            {
                Console.WriteLine(i);
            }
        }

    }
}

