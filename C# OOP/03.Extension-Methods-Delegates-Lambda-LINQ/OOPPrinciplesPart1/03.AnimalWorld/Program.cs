//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
//Create arrays of different kinds of animals and calculate the average age of each kind of 
//animal using a static method (you may use LINQ).
namespace _03.AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
                new Dog("Sharo", 3, true),
                new Dog("Rex", 7, true),
                new Dog("Daisy", 4, false),
                new Dog("Lazy", 9, false),
                new Dog("Robert", 5, true)
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Trevor", 1, true),
                new Frog("NaTrevorBrata", 2, true),
                new Frog("NaTrevorSestrata", 2, false)
            };

            Cat[] cats = new Cat[]
            {
                new Kitten("Lisa", 3),
                new Tomcat("Tom", 4),
                new Tomcat("Jerry", 4),
                new Kitten("Lolita", 2),
                new Cat("Jorjo", 5, true)
            };

            Console.WriteLine("Dog goes: ");
            dogs[0].MakeNoise();
            Console.WriteLine("Frog goes: ");
            frogs[0].MakeNoise();
            Console.WriteLine("Cat goes: ");
            cats[4].MakeNoise();
            Console.WriteLine("WHAT DOES THE FOX SAY? :)");

            Console.WriteLine("The fox says:" + "\n\r" + "The average age for the dogs is: {0}", CalculateAverageAge(dogs));
            Console.WriteLine("The average age for the cats is: {0}", CalculateAverageAge(cats));
            Console.WriteLine("The average age for the frogs is: {0}", CalculateAverageAge(frogs));
        }

        static double CalculateAverageAge(Animal[] animals)
        {
            double averageAge = animals.Average((x) => x.Age);

            return averageAge;
        }
    }
}
