using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
