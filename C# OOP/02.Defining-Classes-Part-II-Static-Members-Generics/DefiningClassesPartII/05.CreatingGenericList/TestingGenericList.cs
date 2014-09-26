namespace _05.CreatingGenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestingGenericList
    {
        static void Main()
        {
            GenericList<int> listOfIntegers = new GenericList<int>();

            for (int i = 0; i < 50; i++)
            {
                listOfIntegers.Add(i);
            }

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(listOfIntegers[i]);
            }

            listOfIntegers.Remove(15);
            Console.WriteLine();
            Console.WriteLine(listOfIntegers[15]);
            Console.WriteLine();
            listOfIntegers.Insert(100, 2);
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                Console.WriteLine(listOfIntegers[i]);
            }
            Console.WriteLine();
            listOfIntegers.FindElement<int>(100, listOfIntegers);
           //Console.WriteLine(listOfIntegers[4]);

            Console.WriteLine("Min element is {0}", listOfIntegers.Min<int>());
            Console.WriteLine("Max element is {0}", listOfIntegers.Max<int>());

        }
    }
}
