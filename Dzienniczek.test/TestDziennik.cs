using System;
using DziennikUcznia;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Dzienniczek.test
{
    [TestClass]
    public class TestPrzyklad
    {
        [TestMethod]
        public void TestNp()
        {
            bool zm = true;
            Assert.IsTrue(zm);
        }
    }

    [TestClass]
    public class TestDziennik
    {
        [TestMethod]
        public void TestDzienniczka()
        {
            Dziennik dziennik = new Dziennik();

            dziennik.podajOcene(5);
            dziennik.podajOcene(4);
            dziennik.podajOcene(9);
            dziennik.podajOcene(4);
            double sr = dziennik.sredniaOcen();
            Assert.AreEqual(sr, 5.5);

        }
    }

}
