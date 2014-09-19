using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing 
//XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        public static string Encode(string stringToBeEncoded,string cipher)
        {
            char[] cipherArray = cipher.ToCharArray();
            char[] stringArray = stringToBeEncoded.ToCharArray();
            int j = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {

                stringArray[i] ^= cipher[j];

                //reset j;
                j++;
                if (j % cipher.Length == 0)
                {
                    j = 0;
                }
            }
            string s = new string(stringArray);
            return s;
        }

        public static string Decode(string stringToDecode, string cipher)
        {
            return Encode(stringToDecode, cipher);
        }

        static void Main(string[] args)
        {
            string cipher = "wtf";

            Console.WriteLine("Enter your string:");
            string enteredString = Console.ReadLine();


            string encodedString = Encode(enteredString, cipher);

            Console.WriteLine(encodedString);

            encodedString = Decode(encodedString, cipher);

            Console.WriteLine(encodedString);
        }
    }
}
