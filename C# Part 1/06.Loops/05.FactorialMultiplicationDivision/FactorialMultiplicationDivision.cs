using System;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class FactorialMultiplicationDivision
{
    static void Main()
    {
        int n, k;
        ulong numeratorN = 1;
        ulong numeratorK = 1;
        ulong denomerator = 1;

        do
        {
            Console.WriteLine("Enter value for n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for k: ");
            k = int.Parse(Console.ReadLine());

        } while (!(1 < n && n < k));

        for (int i = 1; i <= k; i++)
        {
            numeratorN *= (ulong)i;
        }
        for (int i = 1; i <= n; i++)
        {
            numeratorK *= (ulong)i;
        }
        for (int i = 1; i <= (k-n); i++)
        {
            denomerator *= (ulong)i;
        }
        Console.WriteLine("{0}!*{1}! / ({1}-{0})! = {2}",n,k,(numeratorK*numeratorN/denomerator));

    }
}

