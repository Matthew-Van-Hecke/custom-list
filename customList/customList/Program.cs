using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<IComparable> customList = new CustomList<IComparable>();
            CustomList<IComparable> sortedList;
            int firstStringToAdd = 12;
            int secondStringToAdd = 1;
            int thirdStringToAdd = 234;
            int fourthStringToAdd = 78;
            int fifthStringToAdd = 90;
            int sixthStringToAdd = 0;
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            customList.Add(fifthStringToAdd);
            customList.Add(sixthStringToAdd);
            sortedList = CustomList<IComparable>.Sort(customList);
            //Assert
            foreach (IComparable item in sortedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
