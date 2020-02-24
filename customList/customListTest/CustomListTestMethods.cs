using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace customListTest
{
    [TestClass]
    public class CustomListTestMethods
    {
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd = 3;
            int expected = 1;
            //Act
            customList.Add(valueToAdd);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_OneValue_AddedValueIsAtZeroIndex()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd = 3;
            int expected = 3;
            //Act
            customList.Add(valueToAdd);
            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Add_TwoValues_CountIsSameAsNumberOfItemsAdded()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 7;
            int expected = 2;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_TwoValues_SecondItemAddedIsAtIndexOne()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int expected = valueToAdd2;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            //Assert
            Assert.AreEqual(expected, customList[1]);
        }
        [TestMethod]
        public void Add_FiveValues_CountEqualsNumberOfItemsAdded()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int expected = 5;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Add_FiveValues_LastItemAddedIsAtIndexFour()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int expected = valueToAdd5;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            //Assert
            Assert.AreEqual(expected, customList[4]);
        }
        [TestMethod]
        public void Add_FiveValues_FirstItemAddedIsAtIndexZero()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int expected = valueToAdd1;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Remove_OneValueFromIndexZeroOfListOfFive_CountEqualsOriginalCountMinusOne()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int valueToRemove = 3;
            int expected = 4;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            customList.Remove(valueToRemove);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Remove_OneValueFromIndexZeroFromListOfFive_ValueAtIndexZeroEqualsFormerValueAtIndexOne()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int valueToRemove = 3;
            int expected;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            expected = customList[1];
            customList.Remove(valueToRemove);
            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void Remove_TwoConsecutiveValuesFromIndicesOneAndTwoFromListOfFive_ValueAtIndexOneEqualsFormerValueAtIndexThree()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int valueToRemove1 = 12;
            int valueToRemove2 = 8;
            int expected;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            expected = customList[3];
            customList.Remove(valueToRemove1);
            customList.Remove(valueToRemove2);
            //Assert
            Assert.AreEqual(expected, customList[1]);
        }
        [TestMethod]
        public void Remove_TwoConsecutiveValuesFromIndicesOneAndTwoFromListOfFive_CountHasGoneDownByTwo()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 78;
            int valueToRemove1 = 12;
            int valueToRemove2 = 8;
            int expected;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            expected = customList.Count - 2;
            customList.Remove(valueToRemove1);
            customList.Remove(valueToRemove2);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void Capacity_AddFourValues_CapacityEqualsFour()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int expected = 4;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
        [TestMethod]
        public void Capacity_AddFiveValues_CapacityEqualsEight()
        {
            //Arrange
            CustomList<int> customList = new customList.CustomList<int>();
            int valueToAdd1 = 3;
            int valueToAdd2 = 12;
            int valueToAdd3 = 8;
            int valueToAdd4 = 5;
            int valueToAdd5 = 76;
            int expected = 8;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            customList.Add(valueToAdd5);
            //Assert
            Assert.AreEqual(expected, customList.Capacity);
        }
    }
}
