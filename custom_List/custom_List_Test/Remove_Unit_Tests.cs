using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Remove_Unit_Tests
    {
        [TestMethod]
        public void Remove_RemoveSingleItem_ListBecomesSingleEntry()
        {
            CustomList<int> testList = new CustomList<int>() { 2, 4, 6 };
            int expected = 6;
            int actual;

            testList.Remove(4);
            actual = testList[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveMultipleItems_ListBecomesTwoEntries()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4 };
            int expected = 2;
            int actual;

            testList.Remove(3);
            testList.Remove(1);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveSingleItem_ListBecomesEmpty()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 0;
            int actual;

            testList.Add(1);
            testList.Remove(1);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveBelowExpectedCapacity_ListShrinksBelowOriginalCapacity()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 8;
            int actual;

            testList.Remove(5);
            actual = testList.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_DecreaseIndexLocationByOne_IndexLocationDecreasesOne()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4 };
            int expected = 3;
            int actual;

            testList.Remove(3);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveInvalidItem_ArrayDoesNotChange()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3 };
            int expected = 3;
            int actual;

            testList.Remove(44);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveWhenDuplicateItemPresent_RemovesFirstInstance()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 3, 4 };
            int expected = 3;
            int actual;

            testList.Remove(3);
            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveWhenDuplicateItemPresent_RemovesOnlyFirstInstance()
        {
            CustomList<int> testList = new CustomList<int>() { 3, 3, 3, 3, 3 };
            int expected = 4;
            int actual;


            testList.Remove(3);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
