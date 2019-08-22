using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Combine_Unit_Tests
    {
        [TestMethod]
        public void CombineTwoLists_PutTwoSameSizeListsTogether_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 6;
            int actual;

            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutTwoDifferentSizeListsTogether_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6, 7, 8 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 8;
            int actual;

            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutEmptyListWithFullList_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 4;
            int actual;

            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutTwoListsTogether_NewListItemGoesToCorrectIndexLocation()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 5;
            int actual;

            resultList = list1 + list2;
            actual = resultList[4];

            Assert.AreEqual(expected, actual);
        }
    }
}
