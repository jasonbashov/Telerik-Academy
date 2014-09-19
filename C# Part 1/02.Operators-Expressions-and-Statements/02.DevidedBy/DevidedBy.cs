using System;

//Write a boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 in the same time.

class DevidedBy
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 5 == 0 && a % 7 == 0)
        {
            Console.WriteLine("It can be divided by 5 and 7");
        }
        else
        {
            Console.WriteLine("It can NOT");
        }
    }
}

