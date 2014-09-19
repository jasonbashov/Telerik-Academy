using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).

class FactorialDivision
{
    static void Main()
    {
        int n, k;
        ulong numerator = 1;
        ulong denomerator = 1;

        do
        {
            Console.WriteLine("Enter value for k: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for n: ");
            n = int.Parse(Console.ReadLine());

        } while (!(1 < k && k < n));

        for (int i = 1; i <= n; i++)
        {
            numerator *= (ulong)i;
        }
        for (int i = 1; i <= k; i++)
        {
            denomerator *= (ulong)i;
        }
        Console.WriteLine("{0}!/{1}! = {2}",n,k,(numerator / denomerator)); 
    }
}

