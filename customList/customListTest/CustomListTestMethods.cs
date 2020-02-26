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
            resultingList = listOne.Zip(listTwo);
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
            resultingList = listOne.Zip(listTwo);
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
            resultingList = listOne.Zip(listTwo);
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
            resultingList = listOne.Zip(listTwo);
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
            resultingList = listOne.Zip(listTwo);
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
            actual = listOne.GetCountOfLongerOfTwoLists(listTwo);
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
            actual = listOne.GetCountOfLongerOfTwoLists(listTwo);
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
            CustomList<int> customList = new CustomList<int>();
            int firstValueToAdd = 345;
            int secondValueToAdd = 23;
            int thirdValueToAdd = 1;
            int fourthValueToAdd = 47;
            int expected = 1;
            int actual;
            //Act
            customList.Add(firstValueToAdd);
            customList.Add(secondValueToAdd);
            customList.Add(thirdValueToAdd);
            customList.Add(fourthValueToAdd);
            actual = CustomList<int>.GetLowestIntFromIntList(customList);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_LowestIntIsAtZeroIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> sortedList;
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
            sortedList = CustomList<int>.SortNumericallyLowToHigh(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[0]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_SecondLowestIntIsAtOneIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> sortedList;
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
            sortedList = CustomList<int>.SortNumericallyLowToHigh(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[1]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_ThirdLowestIntIsAtTwoIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> sortedList;
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
            sortedList = CustomList<int>.SortNumericallyLowToHigh(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[2]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_FourthLowestIntIsAtThreeIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> sortedList;
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
            sortedList = CustomList<int>.SortNumericallyLowToHigh(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[3]);
        }
        [TestMethod]
        public void SortNumericallyLowToHigh_FourIntsInList_CountOfSortedListIsSameAsCountOfOriginalList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> sortedList;
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
            sortedList = CustomList<int>.SortNumericallyLowToHigh(customList);
            //Assert
            Assert.AreEqual(expected, sortedList[3]);
        }
        //[TestMethod]
        //public void Alphabetize_FourStringsInList_PutsCorrectStringAtZeroIndex()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstStringToAdd = "James";
        //    string secondStringToAdd = "Bob";
        //    string thirdStringToAdd = "Aaron";
        //    string fourthStringToAdd = "Arthur";
        //    string expected = "Aaron";
        //    //Act
        //    customList.Add(firstStringToAdd);
        //    customList.Add(secondStringToAdd);
        //    customList.Add(thirdStringToAdd);
        //    customList.Add(fourthStringToAdd);
        //    customList.Alphabetize();
        //    //Assert
        //    Assert.AreEqual(expected, customList[0]);
        //}
        //[TestMethod]
        //public void Alphabetize_FourStringsInList_PutsCorrectStringAtOneIndex()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstStringToAdd = "James";
        //    string secondStringToAdd = "Bob";
        //    string thirdStringToAdd = "Aaron";
        //    string fourthStringToAdd = "Arthur";
        //    string expected = "Arthur";
        //    //Act
        //    customList.Add(firstStringToAdd);
        //    customList.Add(secondStringToAdd);
        //    customList.Add(thirdStringToAdd);
        //    customList.Add(fourthStringToAdd);
        //    customList.Alphabetize();
        //    //Assert
        //    Assert.AreEqual(expected, customList[1]);
        //}
        //[TestMethod]
        //public void Alphabetize_FourStringsInList_PutsCorrectStringAtTwoIndex()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstStringToAdd = "James";
        //    string secondStringToAdd = "Bob";
        //    string thirdStringToAdd = "Aaron";
        //    string fourthStringToAdd = "Arthur";
        //    string expected = "Arthur";
        //    //Act
        //    customList.Add(firstStringToAdd);
        //    customList.Add(secondStringToAdd);
        //    customList.Add(thirdStringToAdd);
        //    customList.Add(fourthStringToAdd);
        //    customList.Alphabetize();
        //    //Assert
        //    Assert.AreEqual(expected, customList[2]);
        //}
        //[TestMethod]
        //public void Alphabetize_FourStringsInList_PutsCorrectStringAtThreeIndex()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstStringToAdd = "James";
        //    string secondStringToAdd = "Bob";
        //    string thirdStringToAdd = "Aaron";
        //    string fourthStringToAdd = "Arthur";
        //    string expected = "Arthur";
        //    //Act
        //    customList.Add(firstStringToAdd);
        //    customList.Add(secondStringToAdd);
        //    customList.Add(thirdStringToAdd);
        //    customList.Add(fourthStringToAdd);
        //    customList.Alphabetize();
        //    //Assert
        //    Assert.AreEqual(expected, customList[3]);
        //}
        //[TestMethod]
        //public void Alphabetize_FourStringInList_CountOfSortedListIsSameAsOfUnsortedList()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstStringToAdd = "James";
        //    string secondStringToAdd = "Bob";
        //    string thirdStringToAdd = "Aaron";
        //    string fourthStringToAdd = "Arthur";
        //    int expected = 4;
        //    //Act
        //    customList.Add(firstStringToAdd);
        //    customList.Add(secondStringToAdd);
        //    customList.Add(thirdStringToAdd);
        //    customList.Add(fourthStringToAdd);
        //    customList.Alphabetize();
        //    //Assert
        //    Assert.AreEqual(expected, customList.Count);
        //}
    }
}
