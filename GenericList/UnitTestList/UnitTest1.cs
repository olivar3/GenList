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
        [TestMethod]
        public void overloadplus() 
        {
            //Arrange
            GenericList<int> lista = new GenericList<int>() { };
            GenericList<int> listb = new GenericList<int>() { };
            GenericList<int> listc = new GenericList<int>() { };
            int expectedResult = listc;
            lista.Add(1, 2, 3);
            listb.Add(1, 2, 3);
            listc.Add(lista, listb);
            //Act
            listc.Add(lista, listb);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
        public void overloadplus2()
        {
            //Arrange
            GenericList<string> lista = new GenericList<string>() { };
            GenericList<string> listb = new GenericList<string>() { };
            GenericList<string> listc = new GenericList<string>() { };
            string expectedResult = listc;
            lista.Add("A, B, C");
            listb.Add("d, e, f");
            listc.Add(lista, listb);
            //Act
            listc.Add(lista, listb);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
        public void overloadplus3()
        {
            //Arrange
            GenericList<double> lista = new GenericList<double>() { };
            GenericList<double> listb = new GenericList<double>() { };
            GenericList<double> listc = new GenericList<double>() { };
            double expectedResult = listc;
            lista.Add(1.1, 2.2, 3.3 );
            listb.Add(4.4, 5.5, 6.6);
            listc.Add(lista, listb);
            //Act
            listc.Add(lista, listb);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
        public void overloadminus()
        {
            //Arrange
            GenericList<int> lista = new GenericList<int>() { };
            GenericList<int> listb = new GenericList<int>() { };
            GenericList<int> listc = new GenericList<int>() { };
            int expectedResult = listc;
            lista.Add(1,2);
            listb.Add(4,4);
            listc.Remove(4);
            //Act
            listc.Remove(4);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
        public void overloadminusdouble()
        {
            //Arrange
            GenericList<double> lista = new GenericList<double>() { };
            GenericList<double> listb = new GenericList<double>() { };
            GenericList<double> listc = new GenericList<double>() { };
            double expectedResult = listc;
            lista.Add(1.2, 2.2);
            listb.Add(2.3, 2.3);
            listc.Remove(2.3);
            //Act
            listc.Remove(2.3);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
        public void overloadminusstring()
        {
            //Arrange
            GenericList<string> lista = new GenericList<string>() { };
            GenericList<string> listb = new GenericList<string>() { };
            GenericList<string> listc = new GenericList<string>() { };
            string expectedResult = listc;
            lista.Add("A, B, C");
            listb.Add("D, E, F");
            listc.Remove(lista);
            //Act
            listc.Remove(lista);
            //Assert
            Assert.AreEqual(expectedResult, listc);
        }
    }
}
