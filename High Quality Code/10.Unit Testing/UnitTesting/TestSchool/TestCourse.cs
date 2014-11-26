using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class TestCourse
    {
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
        }

        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        // Use TestInitialize to run code before running each test
        [TestInitialize]
        public void TestInitialize()
        {
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void TestCleanup()
        {
        }
        [TestMethod]
        public void TestConstructorStudents()
        {
            Student pesho = CreatePesho10001();
            List<Student> students = new List<Student>();
            students.Add(pesho);
            Course testCourse = new Course(students);
            Assert.AreSame(pesho, testCourse.Students[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentsNull()
        {
            List<Student> students = null;
            Course testCourse = new Course(students);
            Assert.AreSame(null, testCourse.Students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorStudentsSameID()
        {
            Student pesho = CreatePesho10001();
            Student gosho = new Student("Gosho", 10001);
            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(gosho);
            Course testCourse = new Course(students);
            Assert.AreEqual(testCourse.Students[0].UniqueNumber, testCourse.Students[1].UniqueNumber);
        }

        [TestMethod]
        public void TestAddStudentMethod()
        {
            Student pesho = CreatePesho10001();
            List<Student> students = new List<Student>();
            Course testCourse = new Course(students);
            testCourse.AddStudent(pesho);
            Assert.AreSame(pesho, testCourse.Students[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullStudentMethod()
        {
            Student pesho = null;
            List<Student> students = new List<Student>();
            Course testCourse = new Course(students);
            testCourse.AddStudent(pesho);
            Assert.AreSame(null, testCourse.Students[0]);

        }

        [TestMethod]
        public void TestAddOverMaxCountStudents()
        {
            List<Student> students = new List<Student>();
            for (uint i = 0; i < 30; i++)
            {
                var pesho = new Student("Pesho", 10001u + i);
                students.Add(pesho);
            }
            Course testCourse = new Course(students);
            var gosho = new Student("Gosho", 50001);
            testCourse.AddStudent(gosho);
            Assert.AreEqual(30, testCourse.Students.Count);
        }
        
        [TestMethod]
        public void TestDeleteStudents()
        {
            Student pesho = CreatePesho10001();
            Student gosho = new Student("Gosho", 10002);
            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(gosho);
            Course testCourse = new Course(students);
            testCourse.DeleteStudent(pesho);
            Assert.AreEqual(1, testCourse.Students.Count);
        }

        [TestMethod]
        public void TestDeleteStudentsFromEmptyCourse()
        {
            Student pesho = CreatePesho10001();
            List<Student> students = new List<Student>();
            Course testCourse = new Course(students);
            testCourse.DeleteStudent(pesho);
            Assert.AreEqual(0, testCourse.Students.Count);
        }

        [TestMethod]
        public void TestDeleteWrongStudentsFromCourse()
        {
            Student pesho = CreatePesho10001();
            Student gosho = new Student("Gosho", 10002);
            List<Student> students = new List<Student>();
            students.Add(pesho);
            Course testCourse = new Course(students);
            testCourse.DeleteStudent(gosho);
            Assert.AreEqual(1, testCourse.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestDeleteNullStudent()
        {
            Student pesho = null;
            List<Student> students = new List<Student>();
            Course testCourse = new Course(students);
            testCourse.DeleteStudent(pesho);
            Assert.AreEqual(0, testCourse.Students.Count);

        }

        [Ignore]
        private Student CreatePesho10001()
        {
            return new Student("Pesho", 10001);
        }
    }
}
