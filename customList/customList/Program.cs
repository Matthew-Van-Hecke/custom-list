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
                CustomList<int> listOne = new CustomList<int>();
                CustomList<int> listTwo = new CustomList<int>();
                CustomList<int> resultingList;
                int listOneValueOne = 1;
                int listOneValueTwo = 2;
                int listOneValueThree = 3;
                int listTwoValueOne = 4;
                int listTwoValueTwo = 5;
                int listTwoValueThree = 6;
                //Act
                listOne.Add(listOneValueOne);
                listOne.Add(listOneValueTwo);
                listOne.Add(listOneValueThree);
                listTwo.Add(listTwoValueOne);
                listTwo.Add(listTwoValueTwo);
                listTwo.Add(listTwoValueThree);
                resultingList = listOne + listTwo;
            Console.WriteLine(resultingList.ToString());
            Console.ReadLine();
        }
    }
}
