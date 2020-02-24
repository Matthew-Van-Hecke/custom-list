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
        int currentIndex;
        T[] underlyingArray;
        //Constructor
        public CustomList()
        {
            currentIndex = 0;
            underlyingArray = new T[4];
        }
        //Member Methods
        public void Add(T item)
        {
            //Count should increment
            //Added item should be put in the next slot

            //If the array is full, copy the values over to a new array of twice the size, and insert the newest value to be added at the next index
            currentIndex++;
        }
        public void doubleLengthOfUnderlyingArray()
        {
            T[] temporaryArray = underlyingArray;
            underlyingArray = new T[temporaryArray.Length * 2];
            CopyArray(temporaryArray, underlyingArray);
        }
        public void CopyArray(T[] arrayToBeCopiedFrom, T[] arrayToBeCopiedTo)
        {
            for (int i = 0; i < arrayToBeCopiedFrom.Length; i++)
            {
                arrayToBeCopiedTo[i] = arrayToBeCopiedFrom[i];
            }
        }
    }
}
