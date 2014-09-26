namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Class : ICommentable
    {
        private string id;
        private List<Student> studentsInClass;
        private List<Teacher> setOfTeachers;
        private List<string> comments = new List<string>();

        public Class(string id, params Student[] students)
        {
            this.id = id;
            this.studentsInClass = new List<Student>(students);
            this.setOfTeachers = new List<Teacher>();
        }

       

        public string ID { get; set; }
        public List<Student> StudentsInClass { get { return this.studentsInClass; } }
        public List<Teacher> SetOfTeachers { get { return this.setOfTeachers; } }

        public void AddStudent(Student studentToAdd)
        {
            studentsInClass.Add(studentToAdd);
        }
        public void RemoveStudent(Student student)
        {
            this.studentsInClass.Remove(student);
        }

        public void AddTeacher(Teacher teacherToAdd)
        {
            setOfTeachers.Add(teacherToAdd);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }
        
        

        public void PrintClass()
        {
            Console.WriteLine("Students of class: {0}", id);
            Console.WriteLine("=============================");
            foreach (var student in studentsInClass)
            {
                Console.WriteLine(student.UniqueClassNumber + ": " + student.Name);
                foreach (var comment in student.Comments)
                {
                    if (comment == null)
                    {
                        Console.WriteLine("There are no comments about the student");
                    }
                    else
                    {
                        Console.WriteLine("Comments about the student: " + comment);
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                }
                
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Teachers teaching this class:");
            Console.WriteLine("#############################");
            foreach (var teacher in setOfTeachers)
            {
                Console.WriteLine(teacher.Name);
            }
        }



        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void AddComment()
        {
            throw new NotImplementedException();
        }
    }
}
