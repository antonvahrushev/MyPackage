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
            Assert.AreEqual("Hello my dear Anton", greater.SayHello("Anton"));
        }
    }
}
