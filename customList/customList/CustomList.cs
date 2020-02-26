using System;
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
            positionOfItem = Array.IndexOf(underlyingArray, item);
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
        //public void Alphabetize()
        //{
        //    CustomList<T> temporaryList = this;
        //    string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //    //Loop through numnbers and see if first char of each string until one of the strings starts with a char of that number.
        //    //Make a list of strings starting with that char.
        //    //If there are multiple strings in this new list, look at second char and so on until you are down to one string. Add this string to the resulting list, remove this string from the original list, and continue.
        //}
        //public void SortNumericallyLowToHigh()
        //{
        //    T[] temporaryArray = underlyingArray;
        //    CustomList<T> sorted = new CustomList<T>();

        //}
    }
}
