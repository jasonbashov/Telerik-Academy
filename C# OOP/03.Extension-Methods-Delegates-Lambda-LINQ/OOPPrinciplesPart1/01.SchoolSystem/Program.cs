//01.We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number. 
//Classes have unique text identifier. Teachers have name. Disciplines have name, number
//of lectures and number of exercises. Both teachers and students are people.
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and
//operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", 1);
            Student ivan = new Student("Ivan", 2);
            Student jonTravolta = new Student("John", 3);
            Teacher vanHelsing = new Teacher("Van Helsing");

            Class firstGrade = new Class("Pyrvi klas", pesho, ivan, jonTravolta);
            firstGrade.AddTeacher(vanHelsing);

            jonTravolta.AddComment("Very clever but very lazy");

            firstGrade.PrintClass();

        }
    }
}
