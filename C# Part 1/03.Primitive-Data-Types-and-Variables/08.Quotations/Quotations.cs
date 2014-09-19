using System;

//Declare two string variables and assign them with following value:
//  The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

class Quotations
{
    static void Main()
    {
        string str1 = "The \"use\" of quotations causes difficulties.";
        string str2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}

