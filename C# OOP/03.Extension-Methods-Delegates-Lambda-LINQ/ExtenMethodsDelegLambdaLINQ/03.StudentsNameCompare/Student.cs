//03.Write a method that from a given array of students finds all students whose first name is 
//before its last name alphabetically. Use LINQ query operators.
//
//04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//
//05.Using the extension methods OrderBy() and ThenBy() with 
//lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

namespace _03.StudentsNameCompare
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string secondName;
        private int age;
        private Student[] studentArr;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Student[] StudentArr { get; set; }

        public Student(string firstName, string secondName)
            : this(firstName, secondName, 0)
        {
        }

        public Student(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }
    }

    public class Testing
    {
        public static void FindStudents(Student[] studentArray)
        {
            var someStudents =
                from student in studentArray
                where student.FirstName.CompareTo(student.SecondName) < 0
                select student;

            foreach (var item in someStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }
        }

        public static void FindStudentsByAge(Student[] studentArray)
        {
            var someStudents = from student in studentArray
                               where student.Age >= 18 && student.Age <= 24
                               orderby student.FirstName
                               select student;

            foreach (var item in someStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName + "; Age: " + item.Age);
            }
        }

        public static void SortStudentsByDescending(Student[] studentArray)
        {
            //Lambda
            //var someStudents = studentArray
            //    .OrderByDescending(student => student.FirstName)
            //    .ThenByDescending(student => student.SecondName);

            //LINQ
            var someStudents = from student in studentArray
                               orderby student.FirstName descending, student.SecondName descending
                               select student;

            foreach (var item in someStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }

        }

        public static void Main()
        {
            Student[] studentArray = {
                                          new Student("Angel", "Karaliichev",40),
                                          new Student("Van", "Helsing",27),
                                          new Student("Ivan", "Angelov", 24),
                                          new Student("Boris", "Soltariiski", 23),
                                          new Student("Fifty", "Cent", 18),
                                          new Student("Ceca", "Velichkovich", 22),
                                          new Student("Alone", "Inthedarkness", 20),
                                          new Student("Very", "Old", 99)
                                     };
            FindStudents(studentArray);
            Console.WriteLine("=====================================");
            Console.WriteLine("Students between the age of 18 and 24");
            Console.WriteLine("=====================================");
            FindStudentsByAge(studentArray);
            Console.WriteLine("=====================================");
            Console.WriteLine("05.Sort the students by first name and last name in descending order");
            Console.WriteLine("=====================================");
            SortStudentsByDescending(studentArray);
        }
    }
}
