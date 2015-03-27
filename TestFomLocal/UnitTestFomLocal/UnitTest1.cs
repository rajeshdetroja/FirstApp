using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFomLocal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string r = string.Empty;

            Assert.AreEqual(string.Empty, r);
        }
    }
}
