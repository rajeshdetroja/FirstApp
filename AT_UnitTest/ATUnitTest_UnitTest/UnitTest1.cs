using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ATUnitTest_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest1TestMethod1()
        {
            string s = string.Empty;

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("", s);
        }

        [Test]
        public void UnitTest1TestMethod2()
        {
            string s =null;

            NUnit.Framework.Assert.AreEqual(null, s);
        }

        [Test]
        public void TestMethod3()
        {
            string s = string.Empty;

            NUnit.Framework.Assert.AreEqual("Raju", s);
        }

        [Test]
        public void UnitTest1TestMethod4()
        {
            string s = string.Empty;

            NUnit.Framework.Assert.AreEqual("Null", s);
        }

        
        //TestMethod1Class1 tst = new TestMethod1Class1();        
        
    }
}
