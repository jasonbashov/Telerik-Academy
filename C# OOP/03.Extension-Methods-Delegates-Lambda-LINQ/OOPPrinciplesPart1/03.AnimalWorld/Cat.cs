namespace _03.AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
        {
            base.Name = name;
            base.Age = age;
            base.IsMale = isMale;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }
    }
}
