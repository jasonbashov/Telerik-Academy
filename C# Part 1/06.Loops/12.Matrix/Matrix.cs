using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

class Matrix
{
    static void Main()
    {
        int n = 0;
        int number = 1;
        do
        {
            Console.WriteLine("Enter value for N(N < 20):");
            n = int.Parse(Console.ReadLine());
        } while (!(n < 20));

        
        for (int i = 1; i <= n; i++)
        {
            for (int i2 = 0; i2 < n; i2++)
            {
                Console.Write(number + " ");
                number++;
            }
            number -=(n-1);
            Console.WriteLine();
        }
    }
}

