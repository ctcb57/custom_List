using System;
using custom_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace custom_List_Test
{
    [TestClass]
    public class PrintString_Unit_Tests
    {
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
    }
}
