using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LR04
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FM_3()
        {
            int[] a = { 1, 10, 5, 6, 2 };

            int act = ArrayFind.FindMin(a);

            Assert.AreEqual(0, act, "Ожидался 0");
        }

        [TestMethod]
        public void FM_2()
        {
            int[] a = { -1, 1, 5, 2 };

            int act = ArrayFind.FindMin(a);

            Assert.AreEqual(-1, act, "Ожидался -1");
        }

        [TestMethod]
        public void FM_1()
        {
            int[] a = {};

            int act = ArrayFind.FindMin(a);

            Assert.AreEqual(0, act, "Ожидался 0");
        }

    }
}
