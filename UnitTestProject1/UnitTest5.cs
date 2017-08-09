using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTest5
    {
        [Test]
        public void TestMethod1()
        {

            //Master branch changes

            //This is the changed requestioed tona dfazdf

            Thread.Sleep(2000);
            Debug.WriteLine("Test 5 and Method 1");
        }
        [Test]
        public void TestMethod2()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 5 and Method 2");
        }
        [Test]
        public void TestMethod3()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 5 and Method 3");
        }
        [Test]
        public void TestMethod4()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 5 and Method 4");
        }
    }
}
