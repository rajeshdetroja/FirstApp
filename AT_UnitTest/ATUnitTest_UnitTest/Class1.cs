using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATUnitTest_UnitTest
{
    [TestFixture]
    public static class Class1
    {
        [Test]
        public static void TestMethod1()
        {
            string s = string.Empty;

            Assert.AreEqual("", s);
        }
    }

    [TestFixture]
    public static class Class2
    {
        [Test]
        public static void TestMethod2()
        {
            string s = null;

            Assert.AreEqual(null, s);
        }
    }

    [TestFixture]
    public static class Class3
    {
        [Test]
        public static void TestMethod3()
        {
            string s = string.Empty;

            Assert.AreEqual("Raju", s);
        }
    }

    [TestFixture]
    public static class Class4
    {
        [Test]
        public static void TestMethod4()
        {
            string s = string.Empty;

            Assert.AreEqual("Null", s);
        }
    }

    
}
