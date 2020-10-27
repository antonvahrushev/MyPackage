using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPackage472;

namespace MyPackageTest
{
    [TestClass]
    public class GreaterTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
            var greater = new Greater();
            Assert.AreEqual("Hello Anton", greater.SayHello("Anton"));
        }
    }
}
