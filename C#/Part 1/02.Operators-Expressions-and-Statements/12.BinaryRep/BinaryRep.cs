using System;

//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//	n = 5 (00000101), p=2, v=0 -> 1 (00000001)

class BinaryRep
{
    static void Main()
    {
        Console.WriteLine("Enter bit position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of 0 or 1 for V:");
        int v = int.Parse(Console.ReadLine());
        if (v != 1 && v != 0)
        {
            Console.WriteLine("The value of V is NOT 1 or 0");
        }
        else
        {
            if (v == 1)
            {
                int mask = 1 << p;          
                int result = n | mask;
                Console.WriteLine("When we change bit {0} in number {1}  with 1 the result is:{2}", p, n, result);  
            }
            else
            {
                int mask = ~(1 << p);      
                int result = n & mask;      
                Console.WriteLine("When we change bit {0} in number {1}  with 0 the result is:{2}",p,n,result);
            }
        }
    }
}

