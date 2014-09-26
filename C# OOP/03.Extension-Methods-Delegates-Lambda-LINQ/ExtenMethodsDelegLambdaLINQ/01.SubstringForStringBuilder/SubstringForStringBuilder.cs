namespace _01.SubstringForStringBuilder
{
    //Implement an extension method Substring(int index, int length) for the class StringBuilder that 
    //returns new StringBuilder and has the same functionality as Substring in the class String.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SubstringExtension 
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            if (str.Length <= index)
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            if (str.Length <= index + length)
                throw new IndexOutOfRangeException("The length of the substring exceeds the characters of the StringBuilder after the start index.");
            string temp = str.ToString();

            string substr = temp.Substring(index, length);

            return new StringBuilder(substr);
        }
        
    }

    public class Testing
    {
        public static void Main()
        {
            StringBuilder newString = new StringBuilder("what the ****!?!");

            StringBuilder trimedString = newString.Substring(1, 5);

            Console.WriteLine(trimedString);
        }
    }
}
