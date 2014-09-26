using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolSystem
{
    public class Teacher : People
    {
        private List<Discipline> SetOfDisciplines;
        public List<string> Comments { get { return base.Comments; } }

        public Teacher(string name)
        {
            this.Name = name;
        }

        public override void AddComment(string yourComment)
        {
            base.AddComment(yourComment);
        }
    }
}
