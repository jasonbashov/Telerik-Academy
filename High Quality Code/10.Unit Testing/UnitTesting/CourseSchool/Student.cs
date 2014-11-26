using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private uint uniqueNumber;

        public Student(string name, uint uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == String.Empty)
                {
                    throw new ArgumentException("Name value can not be null or empty");
                }

                this.name = value;
            }
        }


        public uint UniqueNumber
        {
            get
            {
                return uniqueNumber;
            }
            set
            {
                if (value < 10000 || value >99999)
                {
                    throw new ArgumentOutOfRangeException("The student unique number must be between 10000 and 99999");
                }

                this.uniqueNumber = value;
            }
        }

    }
}
