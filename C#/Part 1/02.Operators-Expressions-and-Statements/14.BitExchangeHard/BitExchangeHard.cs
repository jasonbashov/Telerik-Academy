using System;

//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

class BitExchangeHard
{
    static void Main()
    {
        uint number = 0;
        int p = 0;
        int q = 0;
        int k = 0;
        do
        {
            Console.WriteLine(@"!!'p' shouldn't be greater than 'q', and 'k'+'q' shouldn't be greater than 32!!");
            Console.WriteLine("Enter number:");
            number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for p:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for q:");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for k:");
            k = int.Parse(Console.ReadLine());
        }
        while (!(((p + k) <= 32) && ((q + k) <= 32) && number > 0 && p<k));
        
        uint finalresult = number;


        int pp = p;
        int qq = q;

        //With this for() we write out which bits we want to exchange
        for (int i = 1; i <= k; i++, pp++, qq++)
        {
            Console.WriteLine("We want to exchange bit number {0} with bit number {1}", pp, qq);
        }

        for (int i = 1; i <= k; i++, p++, q++)
        {
            uint mask = 1u << p;
            uint nAndMask = finalresult & mask;
            uint bit = nAndMask >> p;
            //Console.WriteLine("The value of the bit number {0} in the integer number {1} is: {2}", bit1, finalresult, bit); here you can check the values of the first bits

            uint secondMask = 1u << q;
            nAndMask = finalresult & secondMask;
            uint secondBit = nAndMask >> q;
            //Console.WriteLine("The value of the bit number {0} in the integer number {1} is: {2}", bit2, finalresult, secondBit); here you can check the values of the second bits
            if (bit == 1 && secondBit == 0)
            {
                uint maska = 1u << q;
                uint result = finalresult | maska;
                maska = ~(1u << p);
                result = result & maska;
                finalresult = result;
            }
            else
            {
                if (bit == 0 && secondBit == 1)
                {
                    uint maska2 = ~(1u << q);
                    uint result = finalresult & maska2;
                    maska2 = 1u << p;
                    result = result | maska2;
                    finalresult = result;
                }
                else
                {
                    Console.WriteLine("The values of bit {0} and bit {1} are the same", p, q);
                }
            }
        }
        Console.WriteLine("When we exchange the bits of numner {0} the result is {1}", number, finalresult);
        Console.WriteLine("First number  as Binary: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Second number as Binary: {0}", Convert.ToString(finalresult, 2).PadLeft(32, '0'));
    }
}

