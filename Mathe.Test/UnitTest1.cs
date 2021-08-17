using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mathe;

namespace Mathe.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            int a = 20;
            int b = 5;
            int result = 0;

            result = Mathematik.Addition(a, b);
            Assert.AreEqual(13, result, "Ist falsch", a, b);
            result = Mathematik.Division(a, b);
            Assert.AreEqual(4, "Verkackt");


        }
        [TestMethod]

        public void Kuletest()
        {
            int a = 20;
            int b = 5;
            int result = 0;

            result = Mathematik.Division(a, b);
            Assert.AreEqual(4, result, "Ist falsch", a, b);


        }
    }
}
