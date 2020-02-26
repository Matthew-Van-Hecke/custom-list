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
            Console.WriteLine(listOne.ToString());
            Console.ReadLine() ;
        }
    }
}
