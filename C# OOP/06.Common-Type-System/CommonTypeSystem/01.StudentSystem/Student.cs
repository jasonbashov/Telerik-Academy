namespace _01.StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int sSN;
        private string permanentAdress;
        private string mobilePhone;
        private string email;
        private string course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        public Student(string firstName, string middleName, string lastName, int sSN, string permanentAdress,
            string mobilePhone, string email, string course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.permanentAdress = permanentAdress;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.course = course;
            this.university = university;
            this.faculty = faculty;
            this.specialty = specialty;
        }

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string MiddleName { get { return this.middleName; } set { this.middleName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public int SSN { get { return this.sSN; } set { this.sSN = value; } }
        public string PermanentAdress { get { return this.permanentAdress; } set { this.permanentAdress = value; } }
        public string MobilePhone { get { return this.mobilePhone; } set { this.mobilePhone = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Course { get { return this.course; } set { this.course = value; } }
        public University University { get { return this.university; } set { this.university = value; } }
        public Faculty Faculty { get { return this.faculty; } set { this.faculty = value; } }
        public Specialty Specialty { get { return this.specialty; } set { this.specialty = value; } }


        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            // If parameter cannot be cast to Student return false.
            var p = obj as Student;
            if ((System.Object)p == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (this.FirstName == p.FirstName) && (this.LastName == p.LastName);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(firstStudent, secondStudent))
            {
                return true;
            }
            // If one is null, but not both, return false.
            if (((object)firstStudent == null) || ((object)secondStudent == null))
            {
                return false;
            }
            // Return true if the fields match:
            return firstStudent.FirstName == secondStudent.FirstName && firstStudent.LastName == secondStudent.LastName;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent == secondStudent);
        }

        public object Clone()
        {
            var result = this.MemberwiseClone();
            (result as Student).University = this.University;
            (result as Student).Faculty = this.Faculty;
            (result as Student).Specialty = this.Specialty;

            return result;
        }

        public int CompareTo(Student other)
        {
            // If other is not a valid object reference, this instance is greater. 
            if (other == null) return 1;

            if (this.LastName != other.LastName)
            {
                return (String.Compare(this.LastName, other.LastName));
            }
            if (this.FirstName != other.FirstName)
            {
                return (String.Compare(this.FirstName, other.FirstName));
            }
            if (this.SSN != other.SSN)
            {
                return (this.SSN - other.SSN);
            }
            return 0;
        }
    }
}
