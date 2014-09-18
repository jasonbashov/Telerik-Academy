using System;

//Write a program that reads a number N and calculates the sum of the first N members
//of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


class FibonaciSum
{
    static void Main()
    {
        ulong prev = 0;
        ulong next = 1;
        ulong result = 0;

        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Sequence of Fibonaci for N = {0}", n);

        for (int i = 0; i < n; i++)
        {

            Console.Write(prev + " ");
            result = prev + next;
            prev = next;
            next = result;
        }
        Console.WriteLine();
        Console.WriteLine("The sum is: {0}", (result - 1));// The sum of all the first N members of the sequence is always the sum of tha last two elements + the value of the last element - 1 
    }
}

