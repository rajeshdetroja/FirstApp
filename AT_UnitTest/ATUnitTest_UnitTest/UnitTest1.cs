using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ATUnitTest_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = string.Empty;

            Assert.AreEqual("", s);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s =null;

            Assert.AreEqual(null, s);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = string.Empty;

            Assert.AreEqual("Raju", s);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = string.Empty;

            Assert.AreEqual("Null", s);
        }
    }
}
