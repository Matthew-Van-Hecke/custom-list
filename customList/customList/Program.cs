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
            CustomList<int> intList = new CustomList<int>();
            intList.Add(9);
            intList.Add(6);
            intList.Add(78);
            intList.Add(34);
            Console.WriteLine(intList[4]);
            Console.ReadLine();
        }
    }
}
