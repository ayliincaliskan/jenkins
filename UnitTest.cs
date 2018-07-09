using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSinifi.Test
{
    [TestClass]
    public class HesapMakinesiTest
    {
        [TestMethod]
        public void HesapMakinesi_Topla_Test()
        {
            int beklenenDeger = 34;

            int sayi1 = 32;
            int sayi2 = 2;

           HesapMakinesi hesapMakinesi = new HesapMakinesi();
            int gercekDeger = hesapMakinesi.Topla(sayi1, sayi2);

            Assert.AreEqual(beklenenDeger, gercekDeger);
        }
    }
    public class HesapMakinesi
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}