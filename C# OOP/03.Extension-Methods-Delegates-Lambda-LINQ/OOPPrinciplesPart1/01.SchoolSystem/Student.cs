namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : People
    {
        private List<string> comments;
        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueClassNumber = uniqueNumber;
            this.comments = new List<string>();
        }

        public List<string> Comments { get { return this.comments; } }

        public int UniqueClassNumber
        {
            get;
            set; //to implement uniqueness
        }

        public void AddComment(string yourComment)
        {
            this.comments.Add(yourComment);
        }
    }
}
