using System;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

class TwoIntegersSum
{
    static void Main()
    {
        decimal factorielN = 1;
        decimal result = 0;

        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for X: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            result += (factorielN *= i)/(decimal)Math.Pow(x,i);
        }

        Console.WriteLine("The sum is {0}",(1 + result));
    }
}

