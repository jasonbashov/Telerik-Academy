namespace _03.AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animal : ISound
    {
        private int age;
        private string name;
        private bool isMale;

        public Animal()
        {
            this.Age = 0;
            this.Name = String.Empty;
            this.IsMale = true;
        }

        public int Age 
        { 
            get { return this.age; } 
            set { this.age = value; } 
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public bool IsMale
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }



        public virtual void MakeNoise()
        {
            Console.WriteLine("SHHIU, ei, ela tuka!");
        }
    }
}
