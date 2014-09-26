//5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the
//list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for 
//adding element, accessing element by index, removing element by index, inserting element at given position, 
//clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing 
//elements at invalid positions.
//
//6.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//
//7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
//You may need to add a generic constraints for the type T.

namespace _05.CreatingGenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T> 
    {
        private const int InitialSize = 16;

        private T[] data;
        private int index;
        //private int count = 0;

        public GenericList()
            : this(InitialSize)
        {
        }

        public GenericList(uint initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size of GenericList must be bigger than 2");
            }

            this.data = new T[initialSize];
            this.index = 0;
        }

        public int Count
        {
            get
            {
                return index;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void Add(T element)
        {
            if (this.index == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[this.index] = element;
            this.index++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.index)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            T[] newArray = new T[data.Length - 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                newArray[i] = data[j];
            }
            this.index--;
            data = newArray;
        }
        public void Clear()
        {
            count = 0;
            data = new T[this.Capacity];
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index >= this.index)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            T[] newArray = new T[data.Length + 1];
            for (int i = 0, j = 0; j < newArray.Length; i++, j++)
            {
                T temp = data[i];
                if (i == index)
                {
                    j++;
                    newArray[i] = element;
                }
                newArray[j] = temp;
            }
            index++;
            data = newArray;
        }

        public void FindElement<T>(T element, GenericList<T> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    Console.WriteLine("The element is at index:{0}", i);
                    return;
                }
            }
            Console.WriteLine("No such element!");
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return this.data[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                this.data[index] = value;
            }
        }
        public override string ToString()
        {
            StringBuilder console = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                console.Append(data[i]);
                console.Append(" ");
            }
            return console.ToString();
        }
        // auto-grow functionality
        private void ResizeData()
        {
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];

            int currentIndex = 0;

            int newIndex = 0;

            while (true)
            {
                if (currentIndex >= this.index)
                {
                    break;
                }


                if (currentIndex < this.index)
                {
                    newData[newIndex] = this.data[currentIndex];
                    newIndex++;
                }

                currentIndex++;
            }

            this.data = newData;
            this.index = newIndex;
        }
        //min<t> and max<t>

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = data.Min();
            return min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            dynamic max = data.Max();
            return max;
        }
    }
}
