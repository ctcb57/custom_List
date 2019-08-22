using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class Iterator_Unit_Test
    {
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
