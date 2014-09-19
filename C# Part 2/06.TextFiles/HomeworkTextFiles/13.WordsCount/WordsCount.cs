using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is 
//contained in another file test.txt. The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

namespace _13.WordsCount
{
    class WordsCount
    {
        public static void FindingWordsInFile(StreamReader testFile, StreamReader wordsFile, StreamWriter resultFile)
        {
            var wordsInFirstFileList = new List<string>();
            var wordsInSecondFileList = new List<string>();

            int count = 0;

            wordsInFirstFileList = SplitWords(testFile);
            wordsInSecondFileList = SplitWords(wordsFile);


            foreach (var word in wordsInSecondFileList)
            {
                for (int i = 0; i < wordsInFirstFileList.Count; i++)
                {
                    if (wordsInFirstFileList[i] == word)
                    {
                        count++;
                    }
                }
                resultFile.WriteLine(word + "- {0} times", count);
                count = 0;
            }
        }


        public static List<string> SplitWords(StreamReader sr)
        {
            var wordsInFileList = new List<string>();

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] wordsInFile = line.Split(' ', '.', ',', '!', '?', ';', ':');
                foreach (var word in wordsInFile)
                {
                    wordsInFileList.Add(word);
                }
                line = sr.ReadLine();
            }
            return wordsInFileList;
        }


        static void Main(string[] args)
        {
            try
            {


                var testFile = File.Open(@"..\..\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var wordsFile = File.Open(@"..\..\words.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var resultFile = File.Open(@"..\..\result.txt", FileMode.OpenOrCreate, FileAccess.Write);
                var sr2 = new StreamReader(wordsFile);
                var sr = new StreamReader(testFile);
                var sw = new StreamWriter(resultFile);


                using (sr)
                {
                    using (sr2)
                    {
                        using (sw)
                        {
                            FindingWordsInFile(sr, sr2, sw);
                        }
                    }
                }

                testFile.Close();
                wordsFile.Close();
                resultFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
