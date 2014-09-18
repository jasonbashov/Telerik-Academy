using System;

//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.

class BitExtraction
{
    static void Main()
    {
        Console.WriteLine("Enter bit position:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int i = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int nAndMask = i & mask;
        int bit = nAndMask >> b;
        Console.WriteLine("The value of the bit number {0} in the integer number {1} is: {2}", b, i, bit);
    }
}

