﻿using System;
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
        [TestMethod]
        public void ToString_ThreeNumbers_ConcatinatesTheStringVersionsOfTheNumbers()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int valueToAdd1 = 30;
            int valueToAdd2 = 31;
            int valueToAdd3 = 75;
            int valueToAdd4 = 12;
            string expected = "30317512";
            string actual;
            //Act
            customList.Add(valueToAdd1);
            customList.Add(valueToAdd2);
            customList.Add(valueToAdd3);
            customList.Add(valueToAdd4);
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddTwoListsTogether_CountOfResultEqualsSumOfCountsOfTwoParts()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int expected = 6;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne + listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList.Count);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddTwoListsTogether_CorrectValueAtIndexZero()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int expected = 1;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne + listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList[0]);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddTwoListsTogether_CorrectValueAtIndexThree()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int expected = 4;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne + listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList[3]);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddTwoListsTogether_CapacityEqualsEight()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int expected = 8;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne + listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList.Capacity);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddThreeListsTogether_CorrectValueAtIndexZero()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int listThreeValueOne = 7;
            int listThreeValueTwo = 8;
            int listThreeValueThree = 9;
            int expected = 1;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listThree.Add(listThreeValueOne);
            listThree.Add(listThreeValueTwo);
            listThree.Add(listThreeValueThree);
            resultingList = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(expected, resultingList[0]);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddThreeListsTogether_CorrectValueAtIndexThree()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int listThreeValueOne = 7;
            int listThreeValueTwo = 8;
            int listThreeValueThree = 9;
            int expected = 4;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listThree.Add(listThreeValueOne);
            listThree.Add(listThreeValueTwo);
            listThree.Add(listThreeValueThree);
            resultingList = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(expected, resultingList[3]);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddThreeListsTogether_CorrectValueAtIndex6()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int listThreeValueOne = 7;
            int listThreeValueTwo = 8;
            int listThreeValueThree = 9;
            int expected = 7;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listThree.Add(listThreeValueOne);
            listThree.Add(listThreeValueTwo);
            listThree.Add(listThreeValueThree);
            resultingList = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(expected, resultingList[6]);
        }
        [TestMethod]
        public void PlusOperatorOverload_AddThreeListsTogether_CountEqualsNine()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 5;
            int listTwoValueThree = 6;
            int listThreeValueOne = 7;
            int listThreeValueTwo = 8;
            int listThreeValueThree = 9;
            int expected = 9;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listThree.Add(listThreeValueOne);
            listThree.Add(listThreeValueTwo);
            listThree.Add(listThreeValueThree);
            resultingList = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(expected, resultingList.Count);
        }
        [TestMethod]
        public void MinusOperatorOverload_SubtractOneListFromAnother_CountEqualsTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 2;
            int listTwoValueThree = 6;
            int expected = 2;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne - listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList.Count);
        }
        [TestMethod]
        public void MinusOperatorOverload_SubtractOneListFromAnother_ValueAtIndexOneEqualsThree()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 2;
            int listTwoValueThree = 6;
            int expected = 3;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = listOne - listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList[1]);
        }
        [TestMethod]
        public void MinusOperatorOverload_SubtractOneListFromAnother_ValueAtIndexTwoEqualsSeven()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listOneValueFour = 5;
            int listOneValueFive = 7;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 2;
            int listTwoValueThree = 6;
            int listTwoValueFour = 3;
            int expected = 7;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listOne.Add(listOneValueFour);
            listOne.Add(listOneValueFive);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listTwo.Add(listTwoValueFour);
            resultingList = listOne - listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList[2]);
        }
        [TestMethod]
        public void MinusOperatorOverload_SubtractOneListFromAnother_ValueAtIndexTwoEqualsEight()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 2;
            int listOneValueThree = 3;
            int listOneValueFour = 5;
            int listOneValueFive = 8;
            int listTwoValueOne = 4;
            int listTwoValueTwo = 3;
            int listTwoValueThree = 6;
            int listTwoValueFour = 2;
            int expected = 8;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listOne.Add(listOneValueFour);
            listOne.Add(listOneValueFive);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listTwo.Add(listTwoValueFour);
            resultingList = listOne - listTwo;
            //Assert
            Assert.AreEqual(expected, resultingList[2]);
        }
        [TestMethod]
        public void Zip_ZipTwoListsOfEqualCountTogether_CountOfResultingListEqualsSumOfCountsOfTwoComponentLists()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int expected = 6;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, resultingList.Count);
        }
        [TestMethod]
        public void Zip_ZipTwoListsOfEqualCountTogether_ValueAtIndexOneIsValueFromIndexZeroOfListTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int expected = 2;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, resultingList[1]);
        }
        [TestMethod]
        public void Zip_ZipTwoListsOfEqualCountTogether_ValueAtIndexTwoEqualsValueAtIndexOneOfListOne()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int expected = 3;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            resultingList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, resultingList[2]);
        }
        [TestMethod]
        public void Zip_ZipTwoListsTogetherListTwoIsLonger_CountOfResultingListEqualsSumOfCountsOfComponentLists()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int listTwoValueFour = 8;
            int expected = 7;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listTwo.Add(listTwoValueFour);
            resultingList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, resultingList.Count);
        }
        [TestMethod]
        public void Zip_ZipTwoListsTogetherListTwoIsLonger_ValueAtIndexSixEqualsValueAtIndexThreeOfListTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultingList;
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int listTwoValueFour = 8;
            int expected = 8;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listTwo.Add(listTwoValueFour);
            resultingList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, resultingList[6]);
        }
        [TestMethod]
        public void GetCountOfLongerOfTwoLists_ListTwoIsLonger_ReturnCountOfListTwo()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int listTwoValueFour = 8;
            int expected = 4;
            int actual;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            listTwo.Add(listTwoValueFour);
            actual = CustomList<int>.GetCountOfLongerOfTwoLists(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetCountOfLongerOfTwoLists_ListOneIsLonger_ReturnCountOfListOne()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listOneValueFour = 45;
            int listOneValueFive = 72;
            int listTwoValueOne = 2;
            int listTwoValueTwo = 4;
            int listTwoValueThree = 6;
            int expected = 5;
            int actual;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listOne.Add(listOneValueFour);
            listOne.Add(listOneValueFive);
            listTwo.Add(listTwoValueOne);
            listTwo.Add(listTwoValueTwo);
            listTwo.Add(listTwoValueThree);
            actual = CustomList<int>.GetCountOfLongerOfTwoLists(listOne, listTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClearList_List_ListHasACountOfZero()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            int listOneValueOne = 1;
            int listOneValueTwo = 3;
            int listOneValueThree = 5;
            int listOneValueFour = 34;
            int listOneValueFive = 73;
            int expected = 0;
            //Act
            listOne.Add(listOneValueOne);
            listOne.Add(listOneValueTwo);
            listOne.Add(listOneValueThree);
            listOne.Add(listOneValueFour);
            listOne.Add(listOneValueFive);
            listOne.ClearList();
            //Assert
            Assert.AreEqual(expected, listOne.Count);
        }
        [TestMethod]
        public void GetLowestIntFromIntList_FourIntsInList_ReturnLowestIntFromList()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sorted;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 1;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sorted = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sorted[0]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_LowestIntIsAtZeroIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 1;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[0]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_SecondLowestIntIsAtOneIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 23;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[1]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_ThirdLowestIntIsAtTwoIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 47;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[2]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_FourthLowestIntIsAtThreeIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 345;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[3]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_CountOfSortedListIsSameAsCountOfOriginalList()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 345;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[3]);
        }
        [TestMethod]
        public void Alphabetize_FourStringsInList_PutsCorrectStringAtZeroIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            string firstStringToAdd = "James";
            string secondStringToAdd = "Bob";
            string thirdStringToAdd = "Aaron";
            string fourthStringToAdd = "Arthur";
            string expected = "Aaron";
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[0]);
        }
        [TestMethod]
        public void Alphabetize_FourStringsInList_PutsCorrectStringAtOneIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            string firstStringToAdd = "James";
            string secondStringToAdd = "Bob";
            string thirdStringToAdd = "Aaron";
            string fourthStringToAdd = "Arthur";
            string expected = "Arthur";
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[1]);
        }
        [TestMethod]
        public void Alphabetize_FourStringsInList_PutsCorrectStringAtTwoIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            string firstStringToAdd = "James";
            string secondStringToAdd = "Bob";
            string thirdStringToAdd = "Aaron";
            string fourthStringToAdd = "Arthur";
            string expected = "Bob";
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[2]);
        }
        [TestMethod]
        public void Alphabetize_FourStringsInList_PutsCorrectStringAtThreeIndex()
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            string firstStringToAdd = "James";
            string secondStringToAdd = "Bob";
            string thirdStringToAdd = "Aaron";
            string fourthStringToAdd = "Arthur";
            string expected = "James";
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[3]);
        }
        [TestMethod]
        public void Foreach_ListOfFourStrings_RunsFourTimes()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string firstValue = "this";
            string secondValue = "is";
            string thirdValue = "a";
            string fourthValue = "test";
            int expected = 4;
            int actual = 0;
            //Act
            list.Add(firstValue);
            list.Add(secondValue);
            list.Add(thirdValue);
            list.Add(fourthValue);
            foreach (string value in list)
            {
                actual++;
            }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Foreach_ListOfFourStrings_ReturnsFourValuesConcatinatedTogether()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string firstValue = "this";
            string secondValue = "is";
            string thirdValue = "a";
            string fourthValue = "test";
            string expected = "thisisatest";
            string actual = "";
            //Act
            list.Add(firstValue);
            list.Add(secondValue);
            list.Add(thirdValue);
            list.Add(fourthValue);
            foreach (string value in list)
            {
                actual += value;
            }
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddAtIndex_AddStringAtIndexThreeToListOfStrings_VerifyThatThisStringIsAtIndexThree()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string firstString = "One";
            string secondString = "Two";
            string thirdString = "Three";
            string fourthString = "Four";
            string fifthString = "Five";
            string sixthString = "Six";
            string stringToBeInserted = "Three-and-a-Half";
            string expected = "Three-and-a-Half";
            //Act
            list.Add(firstString);
            list.Add(secondString);
            list.Add(thirdString);
            list.Add(fourthString);
            list.Add(fifthString);
            list.Add(sixthString);
            list.AddAtIndex(stringToBeInserted, 3);
            //Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void AddAtIndex_AddStringAtIndexThreeToListOfStrings_CountHasIncreasedByOne()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string firstString = "One";
            string secondString = "Two";
            string thirdString = "Three";
            string fourthString = "Four";
            string fifthString = "Five";
            string sixthString = "Six";
            string stringToBeInserted = "Three-and-a-Half";
            int expected = 7;
            //Act
            list.Add(firstString);
            list.Add(secondString);
            list.Add(thirdString);
            list.Add(fourthString);
            list.Add(fifthString);
            list.Add(sixthString);
            list.AddAtIndex(stringToBeInserted, 3);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void AddAtIndex_AddStringAtIndexThreeToListOfStrings_VerifyResultingListUsingToString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string firstString = "One";
            string secondString = "Two";
            string thirdString = "Three";
            string fourthString = "Four";
            string fifthString = "Five";
            string sixthString = "Six";
            string stringToBeInserted = "Three-and-a-Half";
            string expected = "OneTwoThreeThree-and-a-HalfFourFiveSix";
            //Act
            list.Add(firstString);
            list.Add(secondString);
            list.Add(thirdString);
            list.Add(fourthString);
            list.Add(fifthString);
            list.Add(sixthString);
            list.AddAtIndex(stringToBeInserted, 3);
            //Assert
            Assert.AreEqual(expected, list.ToString());
        }
        //[TestMethod]
        //public void FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList_ListOfStringsWithExclusivelyLetterCharacters_ReturnCharWithLowestByteValueFromThoseAtIndexOne()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string firstString = "Four";
        //    string secondString = "Score";
        //    string thirdString = "And";
        //    string fourthString = "Seven";
        //    char expected = 'c';
        //    char actual;
        //    //Act
        //    stringList.Add(firstString);
        //    stringList.Add(secondString);
        //    stringList.Add(thirdString);
        //    stringList.Add(fourthString);
        //    actual = CustomList<string>.FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(stringList, 1);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList_ListOfStringsNotExclusivelyLetterCharacters_ReturnCharWithLowestByteValueFromThoseAtIndexOne()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string firstString = "Four";
        //    string secondString = "Score";
        //    string thirdString = "And";
        //    string fourthString = "Seven";
        //    string fifthString = "1863";
        //    char expected = '8';
        //    char actual;
        //    //Act
        //    stringList.Add(firstString);
        //    stringList.Add(secondString);
        //    stringList.Add(thirdString);
        //    stringList.Add(fourthString);
        //    stringList.Add(fifthString);
        //    actual = CustomList<string>.FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(stringList, 1);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void FindLengthOfLongestStringInList_OneStringIsLongerThanTheRest_ReturnLengthOfLongestString()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string firstString = "Four";
        //    string secondString = "Five";
        //    string thirdString = "And";
        //    string fourthString = "Seven";
        //    string fifthString = "1863";
        //    int expected = 5;
        //    int actual;
        //    //Act
        //    stringList.Add(firstString);
        //    stringList.Add(secondString);
        //    stringList.Add(thirdString);
        //    stringList.Add(fourthString);
        //    stringList.Add(fifthString);
        //    actual = CustomList<string>.FindLengthOfLongestStringInList(stringList);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void FindLengthOfLongestStringInList_TwoStringsAreEqualAndLongest_ReturnLengthOfLongestStrings()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string firstString = "Four";
        //    string secondString = "Score";
        //    string thirdString = "And";
        //    string fourthString = "Seven";
        //    string fifthString = "1863";
        //    int expected = 5;
        //    int actual;
        //    //Act
        //    stringList.Add(firstString);
        //    stringList.Add(secondString);
        //    stringList.Add(thirdString);
        //    stringList.Add(fourthString);
        //    stringList.Add(fifthString);
        //    actual = CustomList<string>.FindLengthOfLongestStringInList(stringList);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
