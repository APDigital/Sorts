using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        int[] Answer = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [TestMethod]
        public void AssertSelectSort()
        {
            int[] Array = { 8, 9, 7, 6, 3, 4, 5, 2, 1 };
            Select select = new Select();
            select.SelectSort(Array);

            Assert.AreEqual(Answer, Array);
        }
        [TestMethod]
        public void AssertInsertionSort()
        {
            int[] Array2 = { 8, 7, 6, 5, 4, 3, 2, 1, 9 };
            Insertion insertion = new Insertion();
            insertion.InsertionSort(Array2);

            Assert.AreEqual(Answer, Array2);
        }
    }
}
