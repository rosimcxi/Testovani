using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Kalkulacka;

namespace KalkulackaTestProject
{
    [TestClass]
    public sealed class Test1
    {
        Calc kalkulacka = new Kalkulacka.Calc();

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // This method is called once for the test assembly, before any tests are run.

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // This method is called once for the test assembly, after all tests are run.
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // This method is called once for the test class, before any tests of the class are run.
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // This method is called once for the test class, after all tests of the class are run.
        }

        [TestInitialize]
        public void TestInit()
        {
            // This method is called before each test method.
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // This method is called after each test method.
        }

        [TestMethod]
        public void TestMethod1()
        {
            // var kalkulacka = new Calc();
            Assert.AreEqual(9, kalkulacka.Secti(4, 5));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, kalkulacka.Deleni(5, 1));
        }
    }
}
