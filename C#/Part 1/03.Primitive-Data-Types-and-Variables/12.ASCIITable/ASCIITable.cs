using System;

//Find online more information about ASCII (American Standard Code for Information Interchange) and
//write a program that prints the entire ASCII table of characters on the console.


class ASCIITable
{
    static void Main()
    {
        char symbol;
        for (int num = 0; num < 127; num++)
        {
            symbol = (char)num;
            Console.WriteLine("{0} : {1}", num, symbol);
        }
    }
}

