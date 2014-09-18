using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between
//them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class IntDivisionFive
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers:");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            int temp = second;
            second = first;
            first = temp;
        }

        int count = 0;

        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("There are {0} numbers that exist between {1} and {2} such that the reminder of the division by 5 is 0", count, first, second);
    }
}

