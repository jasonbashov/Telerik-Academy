namespace _02.ExtensionForIEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> arg)
        {
            dynamic sum = 0;
            foreach (var item in arg)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arg)
        {
            dynamic product = 0;
            foreach (var item in arg)
            {
                product *= (dynamic)item;
                if (product == 0)
                    break;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> arg)
        {
            dynamic min = long.MaxValue;
            foreach (var item in arg)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> arg)
        {
            dynamic max = long.MinValue;
            foreach (var item in arg)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> arg)
        {
            dynamic average = 0, counter = 0;
            foreach (var item in arg)
            {
                average += item;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
        }

        public static void Main()
        { }
    }
}
