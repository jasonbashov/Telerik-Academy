namespace _02.HumansStudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }

        public Student(int grade, string firstName, string secondName)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }
    }
}
