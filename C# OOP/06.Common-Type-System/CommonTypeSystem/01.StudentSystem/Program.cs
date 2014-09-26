//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities 
//and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and
//operators == and !=.
namespace _01.StudentSystem
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
            Student pesho = new Student("pesho", "peshov", "pesharski", 111001, "Sofia",
                "0888888888", "pesho@abv.bg", "2", University.UNSS, Faculty.Economy, Specialty.EconomicsOfTrade);
            Student anotherPesho = new Student("pesho", "nepeshov", "pesharski", 111221, "Varna",
                "0777778888", "pesho2@abv.bg", "3", University.UNSS, Faculty.Economy, Specialty.EconomicsOfTrade);
            Student peshoCopy = null;

            if (pesho.Equals(anotherPesho))
            {
                Console.WriteLine("BRAVO");
            }

            peshoCopy = (pesho.Clone() as Student);

            Console.WriteLine(pesho.CompareTo(peshoCopy));
            Console.WriteLine(pesho.CompareTo(anotherPesho));
        }
    }
}
