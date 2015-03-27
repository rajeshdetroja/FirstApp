using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFomLocal
{
    [TestClass]
    public class UnitTest22
    {
        [TestMethod]
        public void TestMethod1()
        {
            string r = string.Empty;

            Assert.AreEqual(string.Empty, r);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string r = "Raju";

            Assert.AreEqual("Raju", r);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string r = null;

            Assert.AreEqual(null, r);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string r = null;

            Assert.AreEqual(null, r);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string r = null;

            Assert.AreEqual(null, r);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string r = string.Empty;

            Assert.AreEqual("Null", r);
        }
    }
}
