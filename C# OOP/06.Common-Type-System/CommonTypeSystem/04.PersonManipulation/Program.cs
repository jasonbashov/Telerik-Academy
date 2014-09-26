//Create a class Person with two fields – name and age. Age can be
//left unspecified (may contain null value. Override ToString() to display 
//the information of a person and if age is not specified – to say so. Write a program to test this functionality.
namespace _04.PersonManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("ivan");
            Person pesho = new Person("pesho", 22);

            Console.WriteLine(ivan.ToString());
            Console.WriteLine(pesho.ToString());
        }
    }
}
