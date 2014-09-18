using System;

//We are given 5 integer numbers.
//Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

class SumOfSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integers: ");
        int i1 = int.Parse(Console.ReadLine());
        int i2 = int.Parse(Console.ReadLine());
        int i3 = int.Parse(Console.ReadLine());
        int i4 = int.Parse(Console.ReadLine());
        int i5 = int.Parse(Console.ReadLine());

        int counter = 0;

        if (i1 + i2 + i3 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) + ({4}) = 0", i1, i2, i3, i4, i5);
            counter++;
        }
        if (i1 + i2 + i3 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", i1, i2, i3, i4);
            counter++;
        }
        if (i1 + i2 + i3 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", i1, i2, i3, i5);
            counter++;
        }
        if (i1 + i2 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", i1, i2, i4, i5);
            counter++;
        }
        if (i1 + i3 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", i1, i3, i4, i5);
            counter++;
        }
        if (i2 + i3 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) + ({3}) = 0", i2, i3, i4, i5);
            counter++;
        }
        if (i1 + i2 + i3 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i2, i3);
            counter++;
        }
        if (i1 + i2 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i2, i4);
            counter++;
        }
        if (i1 + i2 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i2, i3);
            counter++;
        }
        if (i1 + i3 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i3, i4);
            counter++;
        }
        if (i1 + i3 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i3, i5);
            counter++;
        }
        if (i1 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i1, i4, i5);
            counter++;
        }
        if (i2 + i3 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i2, i3, i4);
            counter++;
        }
        if (i2 + i3 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i2, i3, i5);
            counter++;
        }
        if (i2 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i2, i4, i5);
            counter++;
        }
        if (i3 + i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) + ({2}) = 0", i3, i4, i5);
            counter++;
        }
        if (i1 + i2 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i1, i2);
            counter++;
        }
        if (i1 + i3 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i1, i3);
            counter++;
        }
        if (i1 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i1, i4);
            counter++;
        }
        if (i1 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i1, i5);
            counter++;
        }
        if (i2 + i3 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i2, i3);
            counter++;
        }
        if (i2 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i2, i4);
            counter++;
        }
        if (i2 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i2, i5);
            counter++;
        }
        if (i3 + i4 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i3, i4);
            counter++;
        }
        if (i3 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i3, i5);
            counter++;
        }
        if (i4 + i5 == 0)
        {
            Console.WriteLine("({0}) + ({1}) = 0", i4, i5);
            counter++;
        }

        if (counter > 0)
        {
            Console.WriteLine("There are {0} subsets the sum of them is 0", counter);
        }
        else
        {
            Console.WriteLine("There are no subsets the sum of them is 0");
        }
    }
}

