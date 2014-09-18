using System;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class MinMax
{
    static void Main()
    {
        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter your {0} number: ", i);
            int temp = int.Parse(Console.ReadLine());
            if (min > temp)
            {
                min = temp;
            }
            if (max < temp)
            {
                max = temp;
            }
        }
        Console.WriteLine("The minimal values is: {0} and the maximum is: {1}", min, max);
    }
}

