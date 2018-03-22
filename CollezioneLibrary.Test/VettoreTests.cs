using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollezioneLibrary;

namespace CollezioneLibrary.Test
{
    [TestClass]
    public class VettoreTests
    {
        [TestMethod]
        public void TestArray1()
        {
            int[] v1 = new int[] { 1, 2, 3, 4 };
            int[] v2 = new int[] { 1, 2, 3, 4 };
            bool sonouguali = (v1 == v2);
            Assert.AreEqual(true,sonouguali);

        }

        [TestMethod]
        public void TestArray2()
        {
            int[] v1 = new int[] { 1, 2, 3, 4 };
            int[] v2 = v1;
            bool sonouguali = (v1 == v2);
            Assert.AreEqual(true, sonouguali);

        }

        [TestMethod]
        public void TestArrayContenuto()
        {
            int[] v1 = new int[] { 1, 2, 3, 4 };
            int[] v2 = new int[] { 1, 2, 3, 4 };
            
            CollectionAssert.AreEqual(v1, v2);

        }

        [TestMethod]
        public void TestArrayOrdinamento()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] { 4,11,13,22};
            int[] vettoreOrdinato = Vettore.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);

        }
    }
}
