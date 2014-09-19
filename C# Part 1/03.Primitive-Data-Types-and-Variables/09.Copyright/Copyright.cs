using System;
using System.Text;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.


class Copyright
{
    static void Main()
    {
        char copy = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;

        byte space = 3;
        for (int i = 0; i < 3; i++)
        {
            for (int spacesLeft = 0; spacesLeft < space; spacesLeft++)
            {
                Console.Write(" ");
            }
            for (int printCR = 0; printCR <= i; printCR++)
            {
                Console.Write(copy);
            }
            for (int spacesRight = 0; spacesRight < i; spacesRight++)
            {
                Console.Write(copy);
            }
            Console.WriteLine();
            space--;
        }
    }
}

