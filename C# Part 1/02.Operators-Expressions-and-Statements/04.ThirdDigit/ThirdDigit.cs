using System;

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Write at least 3 digit number:");
        int a = int.Parse(Console.ReadLine());
        int mask = ((a / 100) % 10);
        if (mask==7||mask==-7)
        {
            Console.WriteLine("The third digit is 7");
        }
        else
        {
            Console.WriteLine("The third digit is NOT 7");
        }
    }
}

