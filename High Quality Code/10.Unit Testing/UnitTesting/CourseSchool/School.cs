using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private List<Student> students;

        public School(List<Student> studentsList)
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
    }
}
