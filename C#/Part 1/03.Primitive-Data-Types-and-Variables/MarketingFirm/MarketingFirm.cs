using System;

//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics – first name, family name, 
//age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.


class MarketingFirm
{
    static void Main()
    {
        string firstName, familyName, idNumber;
        int age;
        char gender;
        int uniqueEN = 27566253;

        Console.WriteLine("Employee's first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Employee's family name:");
        familyName = Console.ReadLine();
        Console.WriteLine("Employee's ID number:");
        idNumber = Console.ReadLine();
        Console.WriteLine("Employee's age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Employee's gender: m/f");
        gender = Convert.ToChar(Console.Read());

        Console.WriteLine("Employee: {0} {1}", firstName, familyName);
        Console.WriteLine("ID: {0}; Age: {1}; Gender: {2}; Unique Employee Number: {3}",idNumber, age, gender, uniqueEN);
    }
}

