using System;

//Write an if statement that examines two integer variables and
//exchanges their values if the first one is greater than the second one.

class ValueExchange
{
    static void Main()
    {
        Console.WriteLine("Enter the first  integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int second = int.Parse(Console.ReadLine());

        if (first>second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        Console.WriteLine("First: {0}; Second: {1}",first,second);
    }
}

