using System;

//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class Fibonacci
{
    static void Main()
    {
        ulong prev = 0;
        ulong next = 1;
        ulong result = 0;

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(prev);
            result = prev + next;
            prev = next;
            next = result;

        }
    }
}

