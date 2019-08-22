using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Subtract_Unit_Tests
    {
        [TestMethod]
        public void SubtractFromList_RemoveSingleInstance_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 5 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            resultList = list1 - list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractFromList_NoDuplicateInstancesPresent_NoChangeToLists()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            resultList = list1 - list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractFromList_SubtractOneItem_ListAfterRemovalChangesIndexLocation()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            resultList = list1 - list2;
            actual = resultList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractFromList_SubtractOneItemWhenMultipleMatchesPresent_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 3, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 1;
            int actual;

            resultList = list1 - list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractFromList_MultipleInstancesSecondList_RemovesAllInstancesInFirstList()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 1, 3, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            resultList = list1 - list2;
            actual = resultList[0];

            Assert.AreEqual(expected, actual);
        }
    }
}
