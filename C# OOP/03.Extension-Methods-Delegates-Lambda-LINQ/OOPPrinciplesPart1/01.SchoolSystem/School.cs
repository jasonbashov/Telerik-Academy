namespace _01.SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private List<Class> classes;

        public Class[] Classes
        {
            get
            {
                return this.classes.ToArray();
            }
        }

        public School(Class[] classes)
        {
            this.classes = new List<Class>(classes);
        }

        public void AddClass(Class @class)
        {
            this.classes.Add(@class);
        }

        public void RemoveClass(Class @class)
        {
            this.classes.Remove(@class);
        }
    }
}
