using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTest3
    {
        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 3 and Method 1");
        }
        [Test]
        public void TestMethod2()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 3 and Method 2");
        }
        [Test]
        public void TestMethod3()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 3 and Method 3");
        }
        [Test]
        public void TestMethod4()
        {
            Thread.Sleep(2000);
            Debug.WriteLine("Test 3 and Method 4");
        }
    }
}
