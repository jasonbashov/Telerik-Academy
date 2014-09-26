namespace _04.PersonManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
            : this(name, null)
        { }

        public Person(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (age == null)
            {
                return (this.name + " age not specified");
            }
            else
                return (this.name + " " + age.ToString());

        }
    }
}
