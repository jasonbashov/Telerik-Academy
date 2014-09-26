namespace _03.AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
        }
        public override void MakeNoise()
        {
            Console.WriteLine("HYS HYS MYAU");
        }
    }
}
