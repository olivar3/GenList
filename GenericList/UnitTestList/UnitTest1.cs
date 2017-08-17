using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericList;
namespace UnitTestList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void addNumberToList()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 5;
            //Act
            list.Add(5);
            
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void addTwoNumbersToList()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 5;
            //Act
            list.Add(5);
            list.Add(8);

            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void addTwoNumbersToListAtOneIndex()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 8;
            //Act
            list.Add(5);
            list.Add(8);

            //Assert
            Assert.AreEqual(expectedResult, GenericList[1]);
        }
        [TestMethod]
        public void addThreeNumbersToList()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 11;
            //Act
            list.Add(5);
            list.Add(8);
            list.Add(11);

            //Assert
            Assert.AreEqual(expectedResult, GenericList[2]);
        }
        [TestMethod]
        public void removeNumberFromList()
        {        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 5;
            //Act
            list.Remove(5);
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void removeTwoNumbersToList()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int expectedResult = 5;
            //Act
            list.Remove(5);
            list.Remove(8);
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void removeThreeNumbersToList()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();// instantiates the list.
            int expectedResult = 5;
            //Act
            list.Remove(5);// executes the add method.
            list.Remove(8);

            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void overridingToString()
        {
            //Arrange
            GenericList<string> list = new GenericList<string>();
            string expectedResult = "hello";
            //Act
            list.ToString("hello");
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void overridingNumbersInStringToString()
        {
            //Arrange
            GenericList<string> list = new GenericList<string>();
            string expectedResult = "67";
            //Act
            list.ToString("67");
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
        [TestMethod]
        public void overridingNumsAndStringsToString()
        {
            //Arrange
            GenericList<string> list = new GenericList<string>();
            string expectedResult = "Age 30";
            //Act
            list.ToString("Age 30");
            //Assert
            Assert.AreEqual(expectedResult, GenericList[0]);
        }
    }
}
