using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.


class ExchangeValues
{
    static void Main()
    {
        int a, b, buff;
        a = 5;
        b = 10;
        Console.WriteLine(a);       //a = 5;
        Console.WriteLine(b);       //b = 10;
        buff = a;
        a = b;
        b = buff;
        Console.WriteLine(a);       //a = 10;
        Console.WriteLine(b);       //b = 5;
    }
}

