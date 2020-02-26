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
            CustomList<string> stringList = new CustomList<string>();
            string firstString = "Four";
            string secondString = "Five";
            string thirdString = "And";
            string fourthString = "Seven";
            string fifthString = "1863";
            int expected = 5;
            int actual;
            //Act
            stringList.Add(firstString);
            stringList.Add(secondString);
            stringList.Add(thirdString);
            stringList.Add(fourthString);
            stringList.Add(fifthString);
            actual = CustomList<string>.FindLengthOfLongestStringInList(stringList);
            //Assert
            Console.WriteLine(expected + ", " + actual);
            Console.ReadLine() ;
        }
    }
}
