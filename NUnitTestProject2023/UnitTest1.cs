using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace NUnitTestProject2023
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Welcome to the C# NUnit Framework!!!");
        }
        public static void Main(string[] args)
        {
            UnitTest1 test = new UnitTest1();
            test.TestMethod1();
        }
    }
}
