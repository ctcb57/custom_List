using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Add_Unit_Tests
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            testList.Add(1);
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2 };
            int expected = 2;
            int actual;

            actual = testList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            testList.Add(198765);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullList_AddsToEndOfList()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 5;
            int actual;

            actual = testList[4];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullListSecondIteration_AddsToEndOfList()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expected = 9;
            int actual;

            actual = testList[8];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddBeyondInitialCapacity_OriginalArrayValuesPopulateInNewArray()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 3;
            int actual;

            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
