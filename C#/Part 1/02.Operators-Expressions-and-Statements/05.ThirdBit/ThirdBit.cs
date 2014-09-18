using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Write an integer:");
        int n = int.Parse(Console.ReadLine());               
        int mask = 1 << 4;        
        int nAndMask = n & mask;  
        int bit = nAndMask >> 4;  
        if(bit==1)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }
    }
}

