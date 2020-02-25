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
            CustomList<string> toDoList = new CustomList<string>();
            CustomList<string> thingsIveDoneToday = new CustomList<string>();
            CustomList<string> remainingTasksToday;
            toDoList.Add("Make Bed");
            toDoList.Add("Make Breakfast");
            toDoList.Add("Eat Breakfast");
            toDoList.Add("Brush Teeth");
            toDoList.Add("Walk Dog");
            toDoList.Add("Go To Work");
            toDoList.Add("8:30 Meeting");

            thingsIveDoneToday.Add("Make Breakfast");
            thingsIveDoneToday.Add("Eat Breakfast");
            thingsIveDoneToday.Add("Walk Dog");

            remainingTasksToday = toDoList - thingsIveDoneToday;

            for (int i = 0; i < remainingTasksToday.Count; i++)
            {
                Console.WriteLine(remainingTasksToday[i]);
            }
            Console.ReadLine();
        }
    }
}
