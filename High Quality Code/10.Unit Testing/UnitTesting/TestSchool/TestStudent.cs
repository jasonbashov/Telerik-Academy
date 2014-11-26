using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class TestStudent
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
        public void TestConstructorName()
        {
            Student pesho = new Student("Pesho", 10001);
            Assert.AreEqual("Pesho", pesho.Name);
        }

        [TestMethod]
        public void TestConstructorUniqueNumber()
        {
            Student pesho = new Student("Pesho", 10002);
            Assert.AreEqual(10002u, pesho.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorNameNull()
        {
            Student pesho = new Student( null, 10003);
            Assert.AreSame(null, pesho.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorNameEmpty()
        {
            Student pesho = new Student("", 10004);
            Assert.AreEqual("", pesho.Name);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorUniqueNumberUnder()
        {
            Student pesho = new Student("Pesho", 0);
            Assert.AreSame(0, pesho.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorUniqueNumberOver()
        {
            Student pesho = new Student("Pesho", 1000000);
            Assert.AreEqual(1000000, pesho.UniqueNumber);
        }
    }
}
