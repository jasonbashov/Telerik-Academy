using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private List<Student> students;

        public Course(List<Student> studentsList)
        {
            this.Students = studentsList;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                ValidateStudentsList(value);

                this.students = value;
            }
        }

        private void ValidateStudentsList(List<Student> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("The student list of the courses can not be null");
            }
            for (int i = 0; i < value.Count; i++)
            {
                for (int j = i + 1; j < value.Count; j++)
                {
                    if (value[i].UniqueNumber == value[j].UniqueNumber)
                    {
                        throw new ArgumentException("There can not be idtentical UniqueNumbers of the student in the courses");
                    }
                }
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("The new student can not be null");
            }
            if (this.Students.Count >= 30)
            {
                Console.WriteLine("There can not be more than 30 students per course");
                return;
            }

            this.Students.Add(student);

            ValidateStudentsList(this.Students);
        }

        public void DeleteStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("The new student can not be null");
            }

            if (this.Students.Count <= 0)
            {
                Console.WriteLine("There can not be less than 0 students per course");
                return;
            }

            if (this.Students.Contains(student))
            {
                this.Students.Remove(student);
            }
            else
            {
                Console.WriteLine("There is no such student it this course");
                return;
            }
        }
    }
}
