using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFomLocal
{
    [TestClass]
    public class UnitTest3
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
            string r = "Raju";

            Assert.AreEqual("Raju Detroja", r);
        }
    }

    [TestClass]
    public class UnitTest4
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

            Assert.AreEqual("Raju Patel", r);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string r = "Raju";

            Assert.AreEqual("Raju Detroja", r);
        }
    }


    [TestClass]
    public class UnitTest5
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
            string r = "Raju";

            Assert.AreEqual("Raju", r);
        }
    }

    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            string r = string.Empty;

            Assert.AreEqual(null, r);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string r = "Raju";

            Assert.AreEqual("Raju Detroja", r);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string r = "Raju";

            Assert.AreEqual("Raju Detroja", r);
        }
    }
}
