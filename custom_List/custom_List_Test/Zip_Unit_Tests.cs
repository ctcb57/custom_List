using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Zip_Unit_Tests
    {
        [TestMethod]

        public void Zip_ZipTwoSameSizeListsTogether_ListsAreZippedTogether()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 6;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoDifferentSizedListsTogether_ListsAreZippedTogether()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> list2 = new CustomList<int>() { 5, 6, 7 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 7;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipEmptyListWithOtherList_OtherListStaysIntact()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoListsTogether_ItemsGoToCorrectIndexLocation()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoDifferentSizedListsTogetherSecondLarger_ListsAreZippedTogether()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 4, 5, 6, 7 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 7;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_FirstListEmpty_OtherListStaysIntact()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            resultList = CustomList<int>.Zip(list1, list2);
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
