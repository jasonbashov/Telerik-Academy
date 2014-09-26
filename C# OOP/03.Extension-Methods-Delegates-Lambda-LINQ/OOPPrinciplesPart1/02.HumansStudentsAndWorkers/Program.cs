//Define abstract class Human with first name and last name. Define new class Student which is derived from 
//Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and
//WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students
//and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list 
//of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by
//first name and last name.
namespace _02.HumansStudentsAndWorkers
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
            List<Student> listOfStudents = new List<Student>()
            {
                new Student(1, "Ivancho", "Ivanov"),
                new Student(2, "Mariika", "Mariikina"),
                new Student(3, "Car", "Kiro"),
                new Student(4, "Krali","Marko"),
                new Student(5, "Bai","Tosho"),
                new Student(1, "Ali", "Reza"),
                new Student(2, "Bob", "Marley"),
                new Student(3, "Tupac", "Shakur"),
                new Student(4, "Osama","Bush"),
                new Student(5, "George", "Laden")
            };

            SortingStudents(listOfStudents);

            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker("Iron","Man", 1200, 10),
                new Worker("Cristiano", "Ronaldo", 1800, 8),
                new Worker("Lionel", "Messi", 1950, 8),
                new Worker("Clark", "Ken", 600, 10),
                new Worker("Van", "Gogh", 760, 8),
                new Worker("Van", "Helsing", 900, 10),
                new Worker("Van", "Buyten", 1000, 8),
                new Worker("Van", "Persie", 1100, 8),
                new Worker("Van", "der Sar", 1050, 8),
                new Worker("Jan","Valjvan", 500, 10)
            };

            Console.WriteLine("=========================");
            Console.WriteLine("Workers list:");
            SortingWorkers(listOfWorkers);

            List<Human> mergedList = new List<Human>(listOfStudents);

            foreach (var worker in listOfWorkers)
            {
                mergedList.Add(worker);
            }

            SortMergeList(mergedList);
            
        }

        public static void SortMergeList(List<Human> listToSort)
        {
            var someHumans = from human in listToSort
                             orderby human.FirstName ascending, human.SecondName ascending
                             select human;

            Console.WriteLine("~~~~~~~THE MERGED LIST~~~~~~~");
            foreach (var human in someHumans)
            {
                Console.WriteLine(human.FirstName + " " +human.SecondName);
            }

        }
        public static void SortingWorkers(List<Worker> listOfWorkers)
        {
            var someWorkers = from worker in listOfWorkers
                              orderby worker.MoneyPerHour() descending
                              select worker;

            foreach (var worker in someWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.SecondName + " Salary per Hour:: " + worker.MoneyPerHour());
            }

        }
        public static void SortingStudents(List<Student> listOfStudents)
        {
            var someStudents = from student in listOfStudents
                               orderby student.Grade ascending
                               select student;

            foreach (var student in someStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName + " from grade: " + student.Grade);
            }
        }

            
    }
}
