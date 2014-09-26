namespace _02.HumansStudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string firstName;
        private string secondName;

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string SecondName
        {
            get { return this.secondName; }
            private set { this.secondName = value; }
        }

        protected Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
    }
}
