using System;
using System.Threading;
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [Category("Test2")]
    public class UnitTest2
    {
        public string classname;
        [SetUp]
        public void setup()
        {
            classname = "two";
            String name = TestContext.CurrentContext.Test.Name;
            String Methodname = TestContext.CurrentContext.Test.MethodName;
            String ID = TestContext.CurrentContext.Test.ID;
            String FullName = TestContext.CurrentContext.Test.FullName;
        }

        [TearDown]
        public void teardown()
        {
            Debug.WriteLine("Teardown");
            if( TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure)){
                Debug.WriteLine("failure count "+TestContext.CurrentContext.Result.FailCount);
            } else if( TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Success)){
                Debug.WriteLine("failure count "+TestContext.CurrentContext.Result.PassCount);
            }
        }

        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(2000);
            Debug.WriteLine(classname + " and Method 1");
        }
        [Test]
        public void TestMethod2()
        {
            Thread.Sleep(2000);
            Debug.WriteLine(classname + " and Method 2");
        }
        [Test]
        public void TestMethod3()
        {
            Thread.Sleep(2000);
            Debug.WriteLine(classname + " and Method 3");
        }
        [Test]
        public void TestMethod4()
        {
            Thread.Sleep(2000);
            Debug.WriteLine(classname + " and Method 4");
        }
    }
}
