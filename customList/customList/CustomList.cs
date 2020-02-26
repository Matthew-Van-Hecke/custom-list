﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    public class CustomList<T>
    {
        //Member Variables
        int count;
        public int Count
        {
            get { return count; }
        }
        int capacity;
        public int Capacity
        {
            get { return capacity; }
        }
        T[] underlyingArray;
        public T this[int index]
        {
            get
            {
                if (0 <= index && index < count)
                {
                    return underlyingArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (0 <= index && index < count)
                {
                    underlyingArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            underlyingArray = new T[capacity];
        }
        //Member Methods
        public void Add(T item)
        {
            //If the array is full, copy the values over to a new array of twice the size, and insert the newest value to be added at the next index
            if (count == capacity)
            {
                doubleLengthOfUnderlyingArray();
            }
            //Added item should be put in the next slot
            underlyingArray[count] = item;
            //Count should increment
            count++;
        }
        public void Remove(T item)
        {
            int positionOfItem;
            positionOfItem = FindIndexOfGivenItem(item);
            //Find first instance of value and remove from array
            //Loop through array starting at that value through to the second to last position replacing each value with the one immediately following it
            for (int i = positionOfItem; i < capacity; i++)
            {
                try
                {
                    underlyingArray[i] = underlyingArray[i + 1];
                }
                catch (IndexOutOfRangeException)
                {
                    underlyingArray[i] = default(T);
                }
            }
            //Decrement count
            count--;
        }
        public int FindIndexOfGivenItem(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (this[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        private void doubleLengthOfUnderlyingArray()
        {
            capacity *= 2;
            T[] temporaryArray = underlyingArray;
            underlyingArray = new T[capacity];
            CopyArray(temporaryArray, underlyingArray);
        }
        private void CopyArray(T[] arrayToBeCopiedFrom, T[] arrayToBeCopiedTo)
        {
            for (int i = 0; i < count; i++)
            {
                arrayToBeCopiedTo[i] = arrayToBeCopiedFrom[i];
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
            {
                result += underlyingArray[i].ToString();
            }
            return result;
        }
        public CustomList<T> Zip(CustomList<T> listToBeZippedIn)
        {
            CustomList<T> resultingList = new CustomList<T>();
            int countOfLongerList = GetCountOfLongerOfTwoLists(listToBeZippedIn);
            for (int i = 0; i< countOfLongerList; i++)
            {
                if (i < count)
                {
                    resultingList.Add(this[i]);
                }
                if (i < listToBeZippedIn.count)
                {
                    resultingList.Add(listToBeZippedIn[i]);
                }
            }
            return resultingList;
        }
        public int GetCountOfLongerOfTwoLists(CustomList<T> otherList)
        {
            if (otherList.count > this.count)
            {
                return otherList.count;
            }
            else
            {
                return this.count;
            }
        }
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            int index = 0;
            while (index < listOne.count)
            {
                newList.Add(listOne[index]);
                index++;
            }
            index = 0;
            while (index < listTwo.count)
            {
                newList.Add(listTwo[index]);
                index++;
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        listOne.Remove(listOne[i]);
                    }
                }
            }
            return listOne;
        }
        public void ClearList()
        {
            int countOfListToClear = count;
            for (int i = 0; i < countOfListToClear; i++)
            {
                Remove(this[0]);
            }
        }
        //public static CustomList<string> Alphabetize(CustomList<string> listToSort)
        //{
        //    CustomList<string> sortedList = new CustomList<string>();
        //    CustomList<string> temporaryList = new CustomList<string>();
        //    char currentChar = CustomList<string>.FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(listToSort, 0);
        //    for (int i = 0; i < listToSort.count; i++)
        //    {
        //        if (listToSort[i][0] == currentChar)
        //        {
        //            temporaryList.Add(listToSort[i]);
        //        }
        //    }
        //    for (int i = 0; i < 
        //    if (temporaryList.count == 1)
        //    {
        //        sortedList.Add(temporaryList[0]);
        //        temporaryList.ClearList();
        //    }
        //    return sortedList;
        //    //Make a list of strings starting with that char.
        //    //If there are multiple strings in this new list, look at second char and so on until you are down to one string. Add this string to the resulting list, remove this string from the original list, and continue.
        //}
        public static char FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(CustomList<string> stringList, int indexAtWhichToLook)
        {
            char firstChar = stringList[0][indexAtWhichToLook];
            for (int i = 0; i < stringList.count; i++)
            {
                if (Convert.ToByte(stringList[i][indexAtWhichToLook]) < Convert.ToByte(firstChar))
                {
                    firstChar = stringList[i][indexAtWhichToLook];
                }
            }
            return firstChar;
        }
        public static int FindLengthOfLongestStringInList(CustomList<string> list)
        {
            CustomList<string> remainingStrings = list;
            int lengthOfLongestString = 0;
            while (remainingStrings.count > 1)
            {
                lengthOfLongestString++;
                for (int i = 0; i < list.count; i++)
                {
                    if (lengthOfLongestString >= list[i].Length)
                    {
                        remainingStrings.Remove(list[i]);
                    }
                }
            }
            return lengthOfLongestString;
        }
        public static CustomList<int> SortNumericallyLowToHigh(CustomList<int> originalList)
        {
            CustomList<int> sortedList = new CustomList<int>();
            while (originalList.count > 0)
            {
                int lowestInt = CustomList<int>.GetLowestIntFromIntList(originalList);
                for (int i = 0; i < originalList.count; i++)
                {
                    if (originalList[i] == lowestInt)
                    {
                        sortedList.Add(lowestInt);
                        originalList.Remove(lowestInt);
                    }
                }
            }
            return sortedList;
        }
        public static int GetLowestIntFromIntList(CustomList<int> intList)
        {
            int lowestInt = intList[0];
            for (int i = 0; i < intList.count; i++)
            {
                if (intList[i] < lowestInt)
                {
                    lowestInt = intList[i];
                }
            }
            return lowestInt;
        }
    }
}
