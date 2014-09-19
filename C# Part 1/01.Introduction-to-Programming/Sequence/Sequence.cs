using System;

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class Sequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; ++i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}

