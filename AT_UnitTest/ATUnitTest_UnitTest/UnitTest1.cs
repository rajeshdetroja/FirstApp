using System;
using NUnit.Framework;


namespace ATUnitTest_UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void UnitTest1TestMethod1()
        {
            string s = string.Empty;

            Assert.AreEqual("", s);
        }

        [Test]
        public void UnitTest1TestMethod2()
        {
            string s =null;

            Assert.AreEqual(null, s);
        }




        [Test]
        public void TestMethod3()
        {
            string s = string.Empty;

            Assert.AreEqual("Raju", s);
        }

        [Test]
        public void UnitTest1TestMethod4()
        {
            string s = string.Empty;

            Assert.AreEqual("Null", s);
        }

        
        //TestMethod1Class1 tst = new TestMethod1Class1();        
        
    }
}
