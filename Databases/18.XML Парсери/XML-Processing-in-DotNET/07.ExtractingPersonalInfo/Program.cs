namespace ExtractingPersonalInfo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    //07.In a text file we are given the name, address and phone number of given person (each at a single line). 
    //Write a program, which creates new XML document, which contains these data in structured XML format.
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\personalInfo.txt");
            var wordsList = new List<string>();
            var personsList = new List<Person>();
            var personalInfoDictionary = new Dictionary<string, string>();
            Person personToBeAdded = new Person();

            //First we read the whole file and gather all necessery info for the persons
            using (reader)
            {
                string line;
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    SeparateWords(line, wordsList);

                    if (wordsList[0] == "Person")
                    {
                        personToBeAdded = new Person();
                    }
                    else
                    {
                        if (personalInfoDictionary.ContainsKey(wordsList[0]))
                        {
                            personalInfoDictionary[wordsList[0]] = wordsList[1];
                        }
                        else
                        {
                            personalInfoDictionary.Add(wordsList[0], wordsList[1]);
                        }
                    }

                    //We have read all the info we need for a single person to be added in the list
                    if (personalInfoDictionary.Count == 3)
                    {
                        personToBeAdded.Name = personalInfoDictionary["name"].Trim();
                        personToBeAdded.Address = personalInfoDictionary["address"].Trim();
                        personToBeAdded.PhoneNumber = personalInfoDictionary["phone number"].Trim();
                        personsList.Add(personToBeAdded);
                        personalInfoDictionary.Clear();
                    }
                    wordsList.Clear();
                }
            }

            XElement personalInfoXml = new XElement("persons");

            foreach (var person in personsList)
            {
                var currentPersonInfoXml = new XElement("person",
                    new XElement("name", person.Name),
                    new XElement("address", person.Address),
                    new XElement("phone", person.PhoneNumber));
                personalInfoXml.Add(currentPersonInfoXml);
            }
            Console.WriteLine("Personal info extracted");
            personalInfoXml.Save("../../PersonsInformation.xml");
        }

        private static void SeparateWords(string line, IList<string> wordsList)
        {
            string[] words = line.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                wordsList.Add(word);
            }
        }
    }
}
