using System;

//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1 -> false.

class PositionBit
{
    static void Main()
    {
        Console.WriteLine("Enter bit position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;        
        int nAndMask = v & mask;  
        int bit = nAndMask >> p;
        if (bit==1)
        {
            Console.WriteLine("The bit at position {0} of the integer {1} has value of 1",p,v);
        }
        else
        {
            Console.WriteLine("The bit at position {0} of the integer {1} has value of 0", p, v);
        }

    }
}

