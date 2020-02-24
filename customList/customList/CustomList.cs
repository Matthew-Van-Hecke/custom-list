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
            get { return underlyingArray[index]; }
            set { underlyingArray[index] = value; }
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
            if (count == underlyingArray.Length)
            {
                doubleLengthOfUnderlyingArray();
            }
            //Added item should be put in the next slot
            underlyingArray[count] = item;
            //Count should increment
            count++;
        }
        public void Remove (T item)
        {
            int positionOfItem;
            positionOfItem = Array.IndexOf(underlyingArray, item);
            //Find first instance of value and remove from array
            //Loop through array starting at that value through to the second to last position replacing each value with the one immediately following it
            for (int i = positionOfItem; i < underlyingArray.Length; i++)
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
    }
}
