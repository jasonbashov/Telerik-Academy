//09.Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.
//
//10.Implement the previous using the same query expressed with extension methods.
//
//11.Extract all students that have email in abv.bg. Use string methods and LINQ.
//
//12.Extract all students with phones in Sofia. Use LINQ.
//
//13.Select all students that have at least one mark Excellent (6) into a new anonymous 
//class that has properties – FullName and Marks. Use LINQ.
//
//14.Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
//
//15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
//
//18.Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
//
//19.Rewrite the previous using extension methods.

namespace _09.StudentsManipulation
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
        private string fn;
        private string email;
        private int groupNumber;
        private string phone;
        private List<Student> studentArr;
        private List<int> marks;


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
        public string FN
        {
            get { return this.fn; }
            set
            {
                if (value == String.Empty)
                {
                    throw new NullReferenceException("The Faculty number can not be an empty string");
                }
                this.fn = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int GroupNumber { get; set; }
        public string Phone { get; set; }
        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
        }

        public List<Student> StudentArr { get; set; }

        #region Constructors
        public Student(string firstName, string secondName)
            : this(firstName, secondName, string.Empty)
        {
        }
        public Student(string firstName, string secondName, string fn)
            : this(firstName, secondName, fn, 0)
        {
        }
        public Student(string firstName, string secondName, string fn, int groupNumber)
            : this(firstName, secondName, fn, groupNumber, string.Empty)
        {
        }
        public Student(string firstName, string secondName, string fn, int groupNumber, string email)
            : this(firstName, secondName, fn, groupNumber, email, String.Empty)
        {
        }

        public Student(string firstName, string secondName, string fn, int groupNumber, string email, string phone,params int[] inputMarks)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.FN = fn;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Phone = phone;
            this.marks = new List<int>(inputMarks);
        }
        #endregion
    }

    public class Tester
    {
        //9
        public static void FindStudentsByGroup(List<Student> studentList, int groupNumber)
        {
            var someStudents = from student in studentList
                               where student.GroupNumber == groupNumber
                               orderby student.FirstName
                               select student;

            foreach (var item in someStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName + " Group: " + item.GroupNumber);
            }
        }
        //10
        public static void FindStudentsByGroupWithExtensionMethods(List<Student> studentList, int groupNumber)
        {
            List<Student> studentsFromGroup2 = studentList.GetListOfStudentsInExactGroup(groupNumber);

            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName + " Group: " + student.GroupNumber);
            }
        }
        //11
        public static void FindStudentsByEmail(List<Student> studentList, string email)
        {
            var someStudents = from student in studentList
                               where student.Email.Substring(student.Email.LastIndexOf("@")) == email
                                        select student;


            foreach (var student in someStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName + " Email: " + student.Email);
            }
        }
        //12
        public static void FindStudentsByPhone(List<Student> studentList)
        {
            var someStudents = from student in studentList
                               where student.Phone.StartsWith("+3592") || student.Phone.StartsWith("02")
                               select student;


            foreach (var student in someStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName + " Phone: " + student.Phone);
            }
        }
        //13
        public static void FindStudentsByMark(List<Student> studentList, int mark)
        {
            var someStudents = from student in studentList
                               where student.Marks.Contains(mark)
                               select student;

            foreach (var student in someStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
        //14
        public static void FindStudentsByMarkExtension(List<Student> studentList, int mark)
        {
            List<Student> failedStudents = studentList.GetListOfStudentsWithNumberOfMarks(mark, mark);

            foreach (var student in failedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }
        }
        //15
        public static void ExtractMarks(List<Student> studentList, int enrolledIn)
        {
            var MarksFromStudentsEnrolledIn2006 = from student in studentList
                                                  where student.FN.EndsWith(enrolledIn.ToString())
                                                  select student.Marks;

            List<int> marks = new List<int>();
            foreach (var mark in MarksFromStudentsEnrolledIn2006)
            {
                marks.AddRange(mark);
            }

            Console.WriteLine(string.Join(", ", marks));
        }
        //18
        public static void FindStudentsByGroup(List<Student> studentList)
        {
            var studentsGroupedByGroupNameWithLinq =
                from student in studentList
                group student by student.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in studentsGroupedByGroupNameWithLinq)
            {
                Console.WriteLine("Group:");
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.SecondName);
                }
                Console.WriteLine("===================");
            }
        }
        //19
        public static void FindStudentsByGroupLambda(List<Student> studentList)
        {
            var studentsGroupedByGroupNameWithLambda = studentList.GroupBy(x => x.GroupNumber).OrderBy(x => x.Key);

            foreach (var currentGroup in studentsGroupedByGroupNameWithLambda)
            {
                Console.WriteLine("Group:");
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.SecondName);
                }
                Console.WriteLine("===================");
            }
        }
        static void Main()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Angel", "Karaliichev","101006", 1, "angelcho@abv.bg", "0299999999", 6,6,6,5,6),
                new Student("Van", "Helsing","202006", 1, "vampireHunter@yahoo.com", "+359212345123",4,5,3,4,5,6),
                new Student("Ivan", "Angelov", "303006", 2, "lud@abv.bg", "+359877333444",3,3,3,4,2,6),
                new Student("Boris", "Soltariiski", "403005", 3, "heavyMetalChalgar@abv.bg", "+359874334144",4,5,4,5,4),
                new Student("Fifty", "Cent", "502005", 2, "iLoveJustinBieber@gmail.com", "07333441114",2,3,2,3,4),
                new Student("Ceca", "Velichkovich", "602005",2, "pile@abv.bg", "+359211434442",4,5,6,6),
                new Student("Alone", "Inthedarkness", "702004",2, "somethingDark@gmail.com", "+359874334442",3,4,5,6),
                new Student("Very", "Old", "803004",3, "theFirstAccount@abv.bg", "+359874555442",2,2,2,2,3)
            };

            Console.WriteLine("Students from group 2:");
            Console.WriteLine("=======================");
            FindStudentsByGroup(studentList, 2);
            Console.WriteLine("=======================");
            Console.WriteLine("Students from group 2 using extension methods:");
            Console.WriteLine("=======================");
            FindStudentsByGroupWithExtensionMethods(studentList, 2);
            Console.WriteLine("=======================");
            Console.WriteLine("Students with abv.bg emails only:");
            Console.WriteLine("=======================");
            FindStudentsByEmail(studentList, "@abv.bg");
            Console.WriteLine("=======================");
            Console.WriteLine("Students with phones in Sofia:");
            Console.WriteLine("=======================");
            FindStudentsByPhone(studentList);
            Console.WriteLine("=======================");
            Console.WriteLine("Students with at least one mark 6:");
            Console.WriteLine("=======================");
            FindStudentsByMark(studentList, 6);
            Console.WriteLine("=======================");
            Console.WriteLine("Students with exactly two marks 2:");
            Console.WriteLine("=======================");
            FindStudentsByMarkExtension(studentList, 2);
            Console.WriteLine("=======================");
            Console.WriteLine("Marks of the sudents enrolled in 2006:");
            Console.WriteLine("=======================");
            ExtractMarks(studentList, 06);
            Console.WriteLine("=======================");
            Console.WriteLine("Sorted strudents by groups:");
            Console.WriteLine("=======================");
            FindStudentsByGroup(studentList);
            Console.WriteLine("=======================");
            Console.WriteLine("Sorted strudents by groups using LAMBDA:");
            Console.WriteLine("=======================");
            FindStudentsByGroupLambda(studentList);
            
        }

    }
}
