using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class BitExchange
{
    static void Main()
    {
        int bit1 = 3;
        Console.WriteLine("Enter number:");
        uint number = uint.Parse(Console.ReadLine());

        int bit2 = 24;
        uint finalresult=number;

        for (int i = 1; i <= 3; i++, bit1++, bit2++)
        {
            uint mask = 1u << bit1;
            uint nAndMask = finalresult & mask;
            uint bit = nAndMask >> bit1;
            //Console.WriteLine("The value of the bit number {0} in the integer number {1} is: {2}", bit1, finalresult, bit); here you can check the values of the first three bits

            uint secondMask = 1u << bit2;
            nAndMask = finalresult & secondMask;
            uint secondBit = nAndMask >> bit2;
            //Console.WriteLine("The value of the bit number {0} in the integer number {1} is: {2}", bit2, finalresult, secondBit); here you can check the values of the second three bits
            if (bit == 1 && secondBit == 0)
            {
                uint maska = 1u << bit2;
                uint result = finalresult | maska;
                maska = ~(1u << bit1);
                result = result & maska;
                finalresult = result;
            }
            else
            {
                if (bit == 0 && secondBit == 1)
                {
                    uint maska2 = ~(1u << bit2);
                    uint result = finalresult & maska2;
                    maska2 = 1u << bit1;
                    result = result | maska2;
                    finalresult = result;
                }
                else
                {
                    Console.WriteLine("The values of bit {0} and bit {1} are the same",bit1,bit2);
                }
            }
        }
        Console.WriteLine("When we exchange the bits of numner {0} the result is {1}", number, finalresult);
        Console.WriteLine("First number  as Binary: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Second number as Binary: {0}", Convert.ToString(finalresult, 2).PadLeft(32, '0'));

    }

}



