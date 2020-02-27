using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    public class CustomList<T> : IEnumerable
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
        public void AddAtIndex(T item, int index)
        {
            CustomList<T> temporaryList = new CustomList<T>();
            while (count > index)
            {
                temporaryList.Add(this[index]);
                Remove(this[index]);
            }
            Add(item);
            foreach (T value in temporaryList)
            {
                Add(value);
            }
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
        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultingList = new CustomList<T>();
            int countOfLongerList = GetCountOfLongerOfTwoLists(listOne, listTwo);
            for (int i = 0; i< countOfLongerList; i++)
            {
                if (i < listOne.count)
                {
                    resultingList.Add(listOne[i]);
                }
                if (i < listTwo.count)
                {
                    resultingList.Add(listTwo[i]);
                }
            }
            return resultingList;
        }
        public static int GetCountOfLongerOfTwoLists(CustomList<T> listOne, CustomList<T> listTwo)
        {
            if (listTwo.count > listOne.count)
            {
                return listTwo.count;
            }
            else
            {
                return listOne.count;
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

        public static CustomList<IComparable> Sort(CustomList<IComparable> listToSort)
        {
            CustomList<IComparable> sortedList = new CustomList<IComparable>();
            sortedList.Add(listToSort[0]);
            listToSort.Remove(listToSort[0]);
            bool itemBelongsAtEndOfList = true;
            //Loop through listToSort
            while (listToSort.count > 0)
            {
                for (int j = 0; j < sortedList.count; j++)
                {
                    if (listToSort[0].CompareTo(sortedList[j]) <= 0)
                    {
                        sortedList.AddAtIndex(listToSort[0], j);
                        listToSort.Remove(listToSort[0]);
                        itemBelongsAtEndOfList = false;
                        break;
                    }
                }
                if (itemBelongsAtEndOfList)
                {
                    CustomList<IComparable>.MoveItemFromToSortedList(listToSort, sortedList, 0);
                }
                itemBelongsAtEndOfList = true;
            }
            return sortedList;
        }
        public static void MoveItemFromToSortedList(CustomList<T> listToSort, CustomList<T> sortedList, int indexFrom)
        {
            sortedList.Add(listToSort[indexFrom]);
            listToSort.Remove(listToSort[indexFrom]);
        }
        //public static CustomList<string> Sort(CustomList<string> listToSort)
        //{
        //    CustomList<string> remainingStringsToBeSorted = listToSort;
        //    CustomList<string> sortedList = new CustomList<string>();
        //    CustomList<string> temporaryList = new CustomList<string>();
        //    int countOfOriginalUnsortedList = listToSort.count;
        //    char currentChar;
        //    while (sortedList.count < countOfOriginalUnsortedList)
        //    {
        //        currentChar = CustomList<T>.FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(remainingStringsToBeSorted, 0);
        //        BuildListOfStringsWhichStartWithCurrentCharInTemporaryListVariable(remainingStringsToBeSorted, temporaryList, currentChar);
        //        int currentIndexOfEachString = 0;
        //        while (temporaryList.count > 1)
        //        {
        //            char earliestCharFoundAtCurrentIndex = CustomList<T>.FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(temporaryList, currentIndexOfEachString);
        //            LookAtParticularIndexOfEachStringAndRemoveStringFromTemporaryListIfNotStartWithEarliestChar(sortedList, remainingStringsToBeSorted, temporaryList, earliestCharFoundAtCurrentIndex, currentIndexOfEachString);
        //            currentIndexOfEachString++;
        //        }
        //        TranferItemToSortedList(sortedList, remainingStringsToBeSorted, temporaryList, 0);
        //    }
        //    return sortedList;
        //}
        //public static void LookAtParticularIndexOfEachStringAndRemoveStringFromTemporaryListIfNotStartWithEarliestChar(CustomList<string> sortedList, CustomList<string> remainingStringsToBeSorted, CustomList<string> temporaryList, char earliestCharFoundAtCurrentIndex, int currentIndexOfEachString)
        //{
        //    for (int i = 0; i < temporaryList.count; i++)
        //    {
        //        if (currentIndexOfEachString >= temporaryList[i].Length - 1)
        //        {
        //            TranferItemToSortedList(sortedList, remainingStringsToBeSorted, temporaryList, i);
        //        }
        //        if (temporaryList[i][currentIndexOfEachString] != earliestCharFoundAtCurrentIndex)
        //        {
        //            temporaryList.Remove(temporaryList[i]);
        //        }
        //    }
        //}
        //public static void TranferItemToSortedList(CustomList<string> sortedList, CustomList<string> remainingStringsToBeSorted, CustomList<string> temporaryList, int index)
        //{
        //    sortedList.Add(temporaryList[index]);
        //    remainingStringsToBeSorted.Remove(temporaryList[index]);
        //    temporaryList.Remove(temporaryList[index]);
        //}
        //public static void BuildListOfStringsWhichStartWithCurrentCharInTemporaryListVariable(CustomList<string> remainingStringsToBeSorted, CustomList<string> temporaryList, char currentChar)
        //{
        //    for (int i = 0; i < remainingStringsToBeSorted.count; i++)
        //    {
        //        if (remainingStringsToBeSorted[i][0] == currentChar)
        //        {
        //            temporaryList.Add(remainingStringsToBeSorted[i]);
        //        }
        //    }
        //}
        //public static char FindEarliestCharWhenLookingAtGivenIndexOfEachStringInList(CustomList<string> stringList, int indexAtWhichToLook)
        //{
        //    char firstChar = stringList[0][indexAtWhichToLook];
        //    for (int i = 0; i < stringList.count; i++)
        //    {
        //        if (Convert.ToByte(stringList[i][indexAtWhichToLook]) < Convert.ToByte(firstChar))
        //        {
        //            firstChar = stringList[i][indexAtWhichToLook];
        //        }
        //    }
        //    return firstChar;
        //}
        //public static int FindLengthOfLongestStringInList(CustomList<string> list)
        //{
        //    CustomList<string> remainingStrings = list;
        //    int lengthOfLongestString = 0;
        //    while (remainingStrings.count > 1)
        //    {
        //        lengthOfLongestString++;
        //        for (int i = 0; i < list.count; i++)
        //        {
        //            if (lengthOfLongestString >= list[i].Length)
        //            {
        //                remainingStrings.Remove(list[i]);
        //            }
        //        }
        //    }
        //    return lengthOfLongestString;
        //}
        //public static CustomList<int> Sort(CustomList<int> originalList)
        //{
        //    CustomList<int> sortedList = new CustomList<int>();
        //    while (originalList.count > 0)
        //    {
        //        int lowestInt = CustomList<int>.GetLowestIntFromIntList(originalList);
        //        for (int i = 0; i < originalList.count; i++)
        //        {
        //            if (originalList[i] == lowestInt)
        //            {
        //                sortedList.Add(lowestInt);
        //                originalList.Remove(lowestInt);
        //            }
        //        }
        //    }
        //    return sortedList;
        //}
        //public static int GetLowestIntFromIntList(CustomList<int> intList)
        //{
        //    int lowestInt = intList[0];
        //    for (int i = 0; i < intList.count; i++)
        //    {
        //        if (intList[i] < lowestInt)
        //        {
        //            lowestInt = intList[i];
        //        }
        //    }
        //    return lowestInt;
        //}

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return underlyingArray[i];
            }
        }
    }
}
