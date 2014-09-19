using System;

//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

class NullValues
{
    static void Main()
    {
        int? intNull = null;
        double? dblNull = null;
        Console.WriteLine(intNull);
        Console.WriteLine(dblNull);

        intNull++;
        dblNull = dblNull + null;
        Console.WriteLine(intNull);
        Console.WriteLine(dblNull);
    }
}

