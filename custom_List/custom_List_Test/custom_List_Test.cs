using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using custom_List;

namespace custom_List_Test
{
    [TestClass]
    public class custom_List_Test
    {
        //All of the Add Method Tests
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(198765);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullList_AddsToEndOfList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToFullListSecondIteration_AddsToEndOfList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 9;
            int actual;
            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList[8];
            //assert
            Assert.AreEqual(expected, actual);
        }

        //All of the remove method tests
    }
}
