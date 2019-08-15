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

        [TestMethod]
        public void Add_AddBeyondInitialCapacity_OriginalArrayValuesPopulateInNewArray()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }


        //All of the remove method tests
        [TestMethod]
        public void Remove_RemoveSingleItem_ListBecomesSingleEntry()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 6;
            int actual;
            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Remove(4);
            actual = testList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveMultipleItems_ListBecomesTwoEntries()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
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
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(5);
            actual = testList.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_DecreaseIndexLocationByOne_IndexLocationDecreasesOne()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveInvalidItem_ArrayDoesNotChange()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(44);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveWhenDuplicateItemPresent_RemovesFirstInstance()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);
            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveWhenDuplicateItemPresent_RemovesOnlyFirstInstance()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Remove(3);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }

        //Unit Tests for overriding the string method

        [TestMethod]
        public void PrintString_PrintStringIfListIsInt_StringsPrint()
        {
            CustomList<int> testList = new CustomList<int>();
            string expected = "12";
            string actual;

            testList.Add(1);
            testList.Add(2);
            actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintString_PrintStringIfListIsBool_StringsPrint()
        {
            CustomList<bool> testList = new CustomList<bool>();
            string expected = "True";
            string actual;

            testList.Add(true);
            actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintString_PrintStringIfListIsString_StringsPrint()
        {
            CustomList<string> testList = new CustomList<string>();
            string expected = "test";
            string actual;

            testList.Add("test");
            actual = testList.ToString();

            Assert.AreEqual(expected, actual);

        }
        //Unit Tests for adding two lists together
        [TestMethod]
        public void CombineTwoLists_PutTwoSameSizeListsTogether_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 6;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutTwoDifferentSizeListsTogether_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 8;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutEmptyListWithFullList_TwoListsCombine()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 4;
            int actual;

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            resultList = list1 + list2;
            actual = resultList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_PutTwoListsTogether_NewListItemGoesToCorrectIndexLocation()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 5;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            resultList = list1 + list2;
            actual = resultList[4];

            Assert.AreEqual(expected, actual);
        }

        //Unit Tests for Subtract Overload
        [TestMethod]
        public void SubtractFromList_RemoveSingleInstance_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(2);
            list2.Add(4);
            list2.Add(5);
            resultList = list1 - list2;
            actual = list1.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractFromList_NoDuplicateInstancesPresent_NoChangeToLists()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            resultList = list1 - list2;
            actual = list1.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractFromList_SubtractOneItem_ListAfterRemovalChangesIndexLocation()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(2);
            list2.Add(5);
            list2.Add(6);
            resultList = list1 - list2;
            actual = list1[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractFromList_SubtractOneItemWhenMultipleMatchesPresent_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(2);
            list2.Add(3);
            list2.Add(6);
            resultList = list1 - list2;
            actual = list1[1];

            Assert.AreEqual(expected, actual);
        }
    }

    

}
