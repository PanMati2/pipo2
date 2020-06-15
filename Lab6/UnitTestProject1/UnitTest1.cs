using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            Silnia liczba = new Silnia();
            Assert.AreEqual(liczba.Oblicz(0), 1);
        }
        [TestMethod]
        public void Silnia_1()
        {
            Silnia liczba = new Silnia();
            Assert.AreEqual(liczba.Oblicz(1), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            Silnia liczba = new Silnia();
            Assert.AreEqual(liczba.Oblicz(5), 120);
        }
    }
}
