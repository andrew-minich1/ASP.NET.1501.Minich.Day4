using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortMatrix;
using InterfaceSort;
using System.Linq;


namespace UnitTestProject1
{
    [TestClass]
    public class SortArrayUnitTest
    {
        [TestMethod]
        public void SortBySumStringTestMethod1()
        {
            int[][] array = new int[4][];
            array[0] = new int[] { 12, 8, 5 };
            array[1] = new int[] { 5, 2, 7, 2 };
            array[2] = new int[] { 1, 9 };
            array[3] = new int[] { 6, 3 };
            Matrix.Sort(array, new SortBySumString(), true);
            Assert.AreEqual(9, array[0].Sum());
        }

        [TestMethod]
        public void SortBySumStringTestMethod2()
        {
            int[][] array = new int[4][];
            array[0] = new int[] { 12, 8, 5 };
            array[1] = new int[] { 5, 2, 7, 2 };
            array[2] = new int[] { 1, 9 };
            array[3] = new int[] { 6, 3 };
            Matrix.Sort(array, new SortBySumString(), false);
            Assert.AreEqual(25, array[0].Sum());
        }

        [TestMethod]
        public void SortByMaxValueTestMethod1()
        {
            int[][] array = new int[4][];
            array[0] = new int[] { 12, 8, 5 };
            array[1] = new int[] { 5, 2, 7, 2 };
            array[2] = new int[] { 1, 9 };
            array[3] = new int[] { 6, 3 };
            Matrix.Sort(array, new SortByMaxValue(), true);
            Assert.AreEqual(6, array[0].Max());
        }

        [TestMethod]
        public void SortByMaxValueTestMethod2()
        {
            int[][] array = new int[4][];
            array[0] = new int[] { 12, 8, 5 };
            array[1] = new int[] { 5, 2, 7, 2 };
            array[2] = new int[] { 1, 9 };
            array[3] = new int[] { 6, 3 };
            Matrix.Sort(array, new SortByMaxValue(), false);
            Assert.AreEqual(12, array[0].Max());
        }
    }
}
