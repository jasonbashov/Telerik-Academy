using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

class Compare
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        float c = 5.00000001f;
        float d = 5.00000003f;
        if (a == b)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        if (c == d)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

