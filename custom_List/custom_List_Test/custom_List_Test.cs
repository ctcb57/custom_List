﻿using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class custom_List_Test
    {
        //All of the Add Method Tests
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


        //All of the remove method tests
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
            CustomList<int> testList = new CustomList<int>(){1, 2, 3, 4, 5};
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

        //Unit Tests for overriding the string method

        [TestMethod]
        public void PrintString_PrintStringIfListIsInt_StringsPrint()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2 };
            string expected = "1, 2";
            string actual;

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

        //Unit Tests for Subtract Overload
        [TestMethod]
        public void SubtractFromList_RemoveSingleInstance_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 5 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            resultList = list1 - list2;
            actual = list1.Count;

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
            actual = list1.Count;

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
            actual = list1[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractFromList_SubtractOneItemWhenMultipleMatchesPresent_NewListHasItemRemoved()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 3, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 3;
            int actual;

            resultList = list1 - list2;
            actual = list1[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractFromList_MultipleInstancesSecondList_RemovesAllInstancesInFirstList()
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>() { 2, 3, 6 };
            CustomList<int> resultList = new CustomList<int>();
            int expected = 2;
            int actual;

            resultList = list1 - list2;
            actual = list1.Count;

            Assert.AreEqual(expected, actual);
        }
        //Zip method unit tests

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

        [TestMethod]
        public void Iterator_AddOneToEachInt_IntsIncreaseByOne()
        {
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3 };
            int expected = 3;
            int actual;
            int i = 0;

            foreach (int value in testList)
            {
                testList[i] = value + 1;
                i++;
            }
            actual = testList[1];

            Assert.AreEqual(expected, actual);
        }
        
    }
    
    

    

}
