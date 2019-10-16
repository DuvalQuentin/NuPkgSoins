using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassesMetier.Tests
{
    [TestClass()]
    public class PrestationTests
    {
        [TestMethod()]
        public void CompareToTest()
        {
            Prestation maPresta = new Prestation("OuiAdrienCBien", new DateTime(2015, 9, 6, 12, 0, 0), new Intervenant("Adry1", "Dairmhan"));
            Prestation maPresta2 = new Prestation("OuiAdrienCMal", new DateTime(2015, 9, 6, 12, 0, 0), new Intervenant("kantain", "Duvallundi"));
            Assert.AreEqual(0, maPresta2.CompareTo(maPresta), "Si égale : Le résultat doit être égale à 0 ");
        }

        [TestMethod()]
        public void CompareToTestV2()
        {
            Prestation maPresta = new Prestation("OuiAdrienCBien", new DateTime(2015, 9, 6, 12, 0, 0), new Intervenant("Adry1", "Dairmhan"));
            Prestation maPresta2 = new Prestation("OuiAdrienCMal", new DateTime(2015, 9, 7, 12, 0, 0), new Intervenant("kantain", "Duvallundi"));
            Assert.AreEqual(1, maPresta2.CompareTo(maPresta), "Si DateActuelle > DatePresta : Le résultat doit être égale à 1 ");
        }

        [TestMethod()]
        public void CompareToTestV3()
        {
            Prestation maPresta = new Prestation("OuiAdrienCBien", new DateTime(2015, 9, 6, 12, 0, 0), new Intervenant("Adry1", "Dairmhan"));
            Prestation maPresta2 = new Prestation("OuiAdrienCMal", new DateTime(2015, 9, 5, 11, 0, 0), new Intervenant("kantain", "Duvallundi"));
            Assert.AreEqual(-1, maPresta2.CompareTo(maPresta), "Si DateActuelle < DatePresta : Le résultat doit être égale à -1 ");
        }

        [TestMethod()]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            Prestation maPresta = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Paul", "Jean"));
            Assert.AreEqual(8, maPresta.SommePourRien(a, b), "la somme doit être égale à 8.");
        }
    }
}