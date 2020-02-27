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
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> sortedList;
            string firstStringToAdd = "James";
            string secondStringToAdd = "Bob";
            string thirdStringToAdd = "Aaron";
            string fourthStringToAdd = "Arthur";
            string fifthStringToAdd = "King George VI";
            string sixthStringToAdd = "Aaron";
            //Act
            customList.Add(firstStringToAdd);
            customList.Add(secondStringToAdd);
            customList.Add(thirdStringToAdd);
            customList.Add(fourthStringToAdd);
            customList.Add(fifthStringToAdd);
            customList.Add(sixthStringToAdd);
            //Assert
            Console.WriteLine(CustomList<string>.Sort(customList));
            Console.ReadLine();
        }
    }
}
