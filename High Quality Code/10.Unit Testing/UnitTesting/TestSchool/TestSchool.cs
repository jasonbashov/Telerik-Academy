using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class TestSchool
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
            var pesho = CreatePesho10001();
            var students = new List<Student>();
            students.Add(pesho);
            School.School testSchool = new School.School(students);
            Assert.AreEqual("Pesho", testSchool.Students[0].Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentsNull()
        {
            List<Student> students = null;
            School.School testSchool = new School.School(students);
            Assert.AreSame(null, testSchool.Students);
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
            School.School testSchool = new School.School(students);
            Assert.AreEqual(testSchool.Students[0].UniqueNumber, testSchool.Students[1].UniqueNumber);
        }

        [TestMethod]
        public void TestConstructorStudentsDifferentID()
        {
            Student pesho = CreatePesho10001();
            Student gosho = new Student("Gosho", 10002);
            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(gosho);
            School.School testSchool = new School.School(students);
            Assert.AreEqual("Pesho", testSchool.Students[0].Name);
        }
        [Ignore]
        private Student CreatePesho10001()
        {
            return new Student("Pesho", 10001);
        }
    }
}
